using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
  public abstract class AProduct
    {
        string name;
        string description;
        string id;
        string imagigeurl;
        int price;

        public AProduct() {  }

        public string Name
        {
            get { 
                return name; 
            }
            set
            {
                this.name = Name;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = Price;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                this.description = Description;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
        }
        public string Image
        {
            get
            {
                return imagigeurl;
            }
            set
            {
                this.imagigeurl = Image;
            }

        }


    }
}
