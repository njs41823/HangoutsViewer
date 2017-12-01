using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HangoutsViewer.ComponentModel
{
    public class SortableBindingList<T> : BindingList<T>
    {
        public SortableBindingList(IList<T> source) : base(source) { }

        public void Sort(Comparison<T> comparison)
        {
            if (!(Items is List<T> list)) return;
            list.Sort(comparison);
        }

        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;
        
        protected override bool SupportsSortingCore => true;
        
        protected override bool IsSortedCore => _isSorted;
        
        protected override ListSortDirection SortDirectionCore => _sortDirection;
        
        protected override PropertyDescriptor SortPropertyCore => _sortProperty;
        
        protected override void RemoveSortCore()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
            _isSorted = false;
        }
        
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _sortProperty = prop;
            _sortDirection = direction;
            if (!(Items is List<T> list)) return;
            list.Sort(Compare);
            _isSorted = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        private int Compare(T lhs, T rhs)
        {
            int result = OnComparison(lhs, rhs);
            if (_sortDirection == ListSortDirection.Descending)
                result = -result;
            return result;
        }

        private int OnComparison(T lhs, T rhs)
        {
            object lhsValue = lhs == null ? null : _sortProperty.GetValue(lhs);
            object rhsValue = rhs == null ? null : _sortProperty.GetValue(rhs);
            if (lhsValue == null)
            {
                return rhsValue == null ? 0 : -1;
            }
            if (rhsValue == null)
            {
                return 1;
            }
            if (lhsValue is IComparable comparable)
            {
                return comparable.CompareTo(rhsValue);
            }
            return lhsValue.Equals(rhsValue) ? 0 : string.Compare(lhsValue.ToString(), rhsValue.ToString(), StringComparison.Ordinal);
        }
    }
}