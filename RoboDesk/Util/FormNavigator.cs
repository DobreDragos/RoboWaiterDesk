using RoboDesk.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RoboDesk.Utils
{
    public class FormNavigator
    {
        public static int TransitionSpeed { get; set; }

        static FormNavigator() { TransitionSpeed = 20; }

        /// <summary>
        /// Opens any form that implements <see cref="IFormBase"/> 
        /// </summary>
        /// <typeparam name="T">The form to open</typeparam>
        /// <param name="formToClose">The form to close that implements <see cref="IFormBase"/></param>
        /// <param name="disposeAll">If true closes all forms that where previously hidden</param>
        /// <returns></returns>
        public static T OpenForm<T>(IFormBase formToClose) where T : IFormBase, new()
        {
            var form = new T();

            if (formToClose != null)
            {
                //remove close application if form is closed
                formToClose.FormClosed -= Form_FormClosed;

                //fade out current form and close it
                FadeOutForm(formToClose);

                //copy width and height to new form
                form.Width = formToClose.Width;
                form.Height = formToClose.Height;
                form.MinimumSize = formToClose.MinimumSize;
            }

            //add event to close application if form is closed
            form.FormClosed += Form_FormClosed;

            //Fade in new form
            FadeInForm(form);
            return form;
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private static void FadeOutForm(IFormBase formToClose)
        {
            
            if (TransitionSpeed > 0)
            {
                formToClose.Opacity = 1;
                while (formToClose.Opacity > 0.1)
                {
                    System.Threading.Thread.Sleep(TransitionSpeed);
                    formToClose.Opacity -= 0.2;
                }
                formToClose.Opacity = 0;
            }

            formToClose.Close();
        }

        private static void FadeInForm(IFormBase form)
        {
            if (TransitionSpeed > 0)
            {
                form.Opacity = 0.1;
                form.Show();
                Application.DoEvents(); //do the render panel events
                while (form.Opacity < 1.0)
                {
                    System.Threading.Thread.Sleep(TransitionSpeed);
                    form.Opacity += 0.2;
                }
            }
            form.Opacity = 1;
        }
    }
}
