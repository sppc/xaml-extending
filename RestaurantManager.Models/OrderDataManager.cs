﻿using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        private List<MenuItem> _MenuItems;
        public List<MenuItem> MenuItems
        {
            get { return _MenuItems; }
            set
            {
                if (value != _MenuItems)
                {
                    _MenuItems = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<MenuItem> _CurrentlySelectedMenuItems;
        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get { return _CurrentlySelectedMenuItems; }
            set
            {
                if (value != _CurrentlySelectedMenuItems)
                {
                    _CurrentlySelectedMenuItems = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
