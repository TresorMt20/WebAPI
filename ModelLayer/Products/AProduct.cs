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
                this.name = value;
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
                this.price = value;
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
                this.description = value;
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
                this.imagigeurl = value;
            }

        }


    }
}
