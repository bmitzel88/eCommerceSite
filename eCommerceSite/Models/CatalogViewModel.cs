namespace eCommerceSite.Models
{
    public class CatalogViewModel
    {

        public CatalogViewModel(List<Product> products, int lastPage, int currPage)
        {
            Products = products;
            LastPage = lastPage;
            CurrentPage = currPage;
        }

        /// <summary>
        /// The full list of products on the catalog
        /// </summary>
        public List<Product> Products { get; private set; }

        /// <summary>
        /// The last page of the catalog
        /// </summary>
        public int LastPage { get; private set; }

        /// <summary>
        /// The current page the user is viewing
        /// </summary>
        public int CurrentPage { get; private set; }
    }
}
