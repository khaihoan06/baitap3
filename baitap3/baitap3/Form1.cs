using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace baitap3
{
    public partial class Form1 : Form
    {
        private List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();
            cmbUnit.SelectedIndex = 0;
            // start with empty list; items will appear after user adds them
            RefreshListView();
        }

        private void RefreshListView()
        {
            listViewItems.Items.Clear();
            foreach (var it in items)
            {
                var lvi = new ListViewItem(it.Code);
                lvi.SubItems.Add(it.Name);
                lvi.SubItems.Add(it.Unit);
                lvi.SubItems.Add(it.Price.ToString("N2", CultureInfo.InvariantCulture));
                lvi.Tag = it;
                listViewItems.Items.Add(lvi);
            }
        }

        private void ClearInputs()
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cmbUnit.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            var name = txtName.Text.Trim();
            var unit = cmbUnit.Text;
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Mã vật tư không được để trống.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (items.Any(x => x.Code.Equals(code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư đã tồn tại.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out var price))
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new Item { Code = code, Name = name, Unit = unit, Price = price };
            items.Add(item);
            RefreshListView();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn một dòng để cập nhật.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = listViewItems.SelectedItems[0];
            if (!(selected.Tag is Item original)) return;

            var newCode = txtCode.Text.Trim();
            var newName = txtName.Text.Trim();
            var newUnit = cmbUnit.Text;
            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out var newPrice))
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If code changed, ensure uniqueness
            if (!original.Code.Equals(newCode, StringComparison.OrdinalIgnoreCase) && items.Any(x => x.Code.Equals(newCode, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư mới trùng với mã đã tồn tại.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            original.Code = newCode;
            original.Name = newName;
            original.Unit = newUnit;
            original.Price = newPrice;
            RefreshListView();
            ClearInputs();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn một dòng để xóa.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show("Bạn chắc chắn muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            var selected = listViewItems.SelectedItems[0];
            if (selected.Tag is Item item)
            {
                items.Remove(item);
            }
            RefreshListView();
            ClearInputs();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn chắc chắn muốn xóa toàn bộ danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;
            items.Clear();
            RefreshListView();
            ClearInputs();
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0) return;
            var selected = listViewItems.SelectedItems[0];
            if (selected.Tag is Item item)
            {
                txtCode.Text = item.Code;
                txtName.Text = item.Name;
                cmbUnit.Text = item.Unit;
                txtPrice.Text = item.Price.ToString("N2", CultureInfo.InvariantCulture);
            }
        }

        private class Item
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Unit { get; set; }
            public decimal Price { get; set; }
        }
    }
}
