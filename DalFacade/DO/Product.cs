
namespace DO { 

    /// <summary>
    /// ישות מוצר
    /// </summary>
    /// <param name="id">מספר מזהה</param>
    /// <param name="name">שם מוצר</param>
    /// <param name="category">קטגוריה</param>
    /// <param name="price">מחיר מוצר</param>
    /// <param name="count">כמות במלאי</param>
    public record Product
    (
        int id,
        string? name,
        Category category,
        double? price,
        int? count
    )
    {
        /// <summary>
        /// בנאי לאתחול שדות / ערכים
        /// </summary>
        public Product() : this(1, "", Category.Cakes, 0.0, 0)
        {

        }

    }

}