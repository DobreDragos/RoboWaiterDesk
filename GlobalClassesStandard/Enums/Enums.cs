using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerHelper.Enums
{
    public enum ErrCode
    {
        UnknownFormStatus = 100,
    }

    public enum ObjectTypeId
    {
        Products_Name = 1,
        Menus_Name,
        Families_Name,
        Products_Description,
        Menus_Description,
        Products_Alergens
    }

    public enum LanguageId
    {
        Ro = 1,
        En = 2
    }

    public enum ExCode
    {
        Unknown = 0,
        HigherAppVersion = 1,
        HigherDbStep = 2,
        LocalDBStepNotExists = 3,
        VersionDoesNotExistInDb = 4,
        MustUpdate = 5,
        InvalidDbStep = 6,
        LoginFailed = 7
    }

    public enum SqlOperators
    {
        [Description("=")]
        equals = 0,
        [Description(">")]
        greater,
        [Description(">=")]
        greaterOrEqual,
        [Description("<")]
        lessThan,
        [Description("<=")]
        lessOrEqual,
        [Description(" LIKE ")]
        startsWidth,
        [Description(" LIKE ")]
        endsWidth,
        [Description(" LIKE ")]
        contains,
        [Description(" LIKE ")]
        like,
        [Description(" <> ")]
        differs
    }
    
    public enum SqlLogicOperators
    {
        [Description("AND")]
        and ,
        [Description("OR")]
        or,
    }

    public enum FormStatus
    {
        /// <summary>
        /// Default state
        /// </summary>
        Normal = 0,
        /// <summary>
        /// New information is added to the form
        /// </summary>
        Add,
        /// <summary>
        /// An existing object/table is modified
        /// </summary>
        Edit
    }
    
    public enum EnabledStatus
    {
        Disabled = 0,
        Enabled = 1
    }

    /// <summary>
    /// A generic enum for Yes an No questions, comboboxes, etc.
    /// </summary>
    public enum GenericResponse
    {
        NO = 0,
        YES = 1
    }
    

    public enum UserRoles
    {
        /// <summary>
        /// Acces everywhere
        /// </summary>
        Admin = 0,
        /// <summary>
        /// Access to modify products, see sales reports, units of measurement
        /// </summary>
        PowerUser,
        /// <summary>
        /// Access to sell only
        /// </summary>
        NormalUser
    }
}
