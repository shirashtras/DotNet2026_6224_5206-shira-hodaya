
namespace DO
{
    /// <summary>
    /// ישות עבור לקוח 
    /// </summary>
    /// <param name="id">תעודת זהות</param>
    /// <param name="nameCustomer">שם הלקוח</param>
    /// <param name="adress">כתובת</param>
    /// <param name="phoneNumber">טלפון</param>
    public record Customer
    (
        int id,
        string? nameCustomer,
        string? adress,
        string? phoneNumber

    )
    {
        /// <summary>
        /// בנאי המאתחל ערכים
        /// </summary>
        public Customer() : this(0, "", "", "")
        {

        }
    }

}