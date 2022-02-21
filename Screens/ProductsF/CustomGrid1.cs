using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PointofSaleSoftware.Screens.ProductsF
{
    [ToolboxItem(true)]
    public class SalesDetail : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("dgv_SalesDet");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new dgv_SalesDetInfoRegistrator());
        }
    }

    public class dgv_SalesDetInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName => "dgv_SalesDet";

        public override BaseView CreateView(GridControl grid)
        {
            return new dgv_SalesDet(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new dgv_SalesDetInfo(view as dgv_SalesDet);
        }

        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new dgv_SalesDetHandler(view as dgv_SalesDet);
        }

        public override BaseViewPainter CreatePainter(BaseView view)
        {
            return new dgv_SalesDetPainter(view as dgv_SalesDet);
        }
    }

    public class dgv_SalesDet : DevExpress.XtraGrid.Views.Grid.GridView
    {
        public dgv_SalesDet()
        {
        }

        public dgv_SalesDet(GridControl grid) : base(grid)
        {
        }

        protected override string ViewName => "dgv_SalesDet";
    }

    public class dgv_SalesDetInfo : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo
    {
        public dgv_SalesDetInfo(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class dgv_SalesDetHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
    {
        public dgv_SalesDetHandler(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class dgv_SalesDetPainter : DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter
    {
        public dgv_SalesDetPainter(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }
}
