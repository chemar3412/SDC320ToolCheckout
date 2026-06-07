/*********************************
Name: Chelsea Martin
Date: 5/31/2026
Assignment: SDC320 Course Project Tool Checkout System
*/

namespace ToolCheckout.Models
{
    public abstract class Identifiable
    {
        public int Id { get; set; }

        protected Identifiable()
        {
        }

        protected Identifiable(int id)
        {
            Id = id;
        }
    }
}
