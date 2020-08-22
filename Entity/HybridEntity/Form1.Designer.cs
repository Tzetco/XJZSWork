using System.Drawing;

namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.Solid, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.DodgerBlue, System.Drawing.Color.WhiteSmoke, 0.75D, null);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magGlassToolBarButton1 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 50D), 600D, new devDept.Geometry.Quaternion(0.086824088833465166D, 0.15038373318043533D, 0.492403876506104D, 0.85286853195244339D), devDept.Graphics.projectionType.Perspective, 50D, 2.2185429359195004D, false);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar1 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            (devDept.Eyeshot.ToolBarButton) homeToolBarButton1,
            (devDept.Eyeshot.ToolBarButton) magGlassToolBarButton1,
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton1))});
            devDept.Eyeshot.Legend legend1 = new devDept.Eyeshot.Legend(0D, 100D, "Title", "Subtitle", new System.Drawing.Point(24, 24), new System.Drawing.Size(10, 30), true, false, false, "{0:0.##}", System.Drawing.Color.Transparent, System.Drawing.Color.Black, System.Drawing.Color.Black, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(127))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(63))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))}, false);
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-50D, -50D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), Color.Transparent, false);
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, false);
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D));
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.DeepSkyBlue, devDept.Eyeshot.Camera.perspectiveFitType.Accurate);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(359, 335), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {toolBar1}, new devDept.Eyeshot.Legend[] {
            legend1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, originSymbol1, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, coordinateSystemIcon1, viewCubeIcon1, savedViewsManager1);
            this.changeNatureButton = new System.Windows.Forms.Button();
            this.model1 = new devDept.Eyeshot.Model();
            this.selectByBoxEnclButton = new System.Windows.Forms.CheckBox();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.invertSelectionButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.selectByBoxButton = new System.Windows.Forms.CheckBox();
            this.selectVisibleByPickButton = new System.Windows.Forms.CheckBox();
            this.selectVisibleByBoxButton = new System.Windows.Forms.CheckBox();
            this.selectByPickButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // changeNatureButton
            // 
            this.changeNatureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeNatureButton.Location = new System.Drawing.Point(377, 12);
            this.changeNatureButton.Name = "changeNatureButton";
            this.changeNatureButton.Size = new System.Drawing.Size(75, 48);
            this.changeNatureButton.TabIndex = 5;
            this.changeNatureButton.Text = "Change Nature";
            this.changeNatureButton.UseVisualStyleBackColor = true;
            this.changeNatureButton.Click += new System.EventHandler(this.changeNatureButton_Click);
            // 
            // model1
            // 
            this.model1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Location = new System.Drawing.Point(12, 13);
            this.model1.MinimumSize = new System.Drawing.Size(8, 8);
            this.model1.Name = "model1";
            this.model1.Size = new System.Drawing.Size(359, 335);
            this.model1.TabIndex = 0;
            viewport1.Legends = new devDept.Eyeshot.Legend[] {
        legend1};
            this.model1.Viewports.Add(viewport1);
            // 
            // selectByBoxEnclButton
            // 
            this.selectByBoxEnclButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectByBoxEnclButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectByBoxEnclButton.Location = new System.Drawing.Point(377, 270);
            this.selectByBoxEnclButton.Name = "selectByBoxEnclButton";
            this.selectByBoxEnclButton.Size = new System.Drawing.Size(75, 23);
            this.selectByBoxEnclButton.TabIndex = 88;
            this.selectByBoxEnclButton.Text = "by Box Encl.";
            this.selectByBoxEnclButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectByBoxEnclButton.UseVisualStyleBackColor = true;
            this.selectByBoxEnclButton.CheckedChanged += new System.EventHandler(this.selectByBoxEnclButton_CheckedChanged);
            // 
            // selectionLabel
            // 
            this.selectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionLabel.AutoSize = true;            
            this.selectionLabel.Location = new System.Drawing.Point(377, 142);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(51, 13);
            this.selectionLabel.TabIndex = 87;
            this.selectionLabel.Text = "Selection";
            // 
            // invertSelectionButton
            // 
            this.invertSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invertSelectionButton.Location = new System.Drawing.Point(377, 326);
            this.invertSelectionButton.Name = "invertSelectionButton";
            this.invertSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.invertSelectionButton.TabIndex = 86;
            this.invertSelectionButton.Text = "Invert";
            this.invertSelectionButton.UseVisualStyleBackColor = true;
            this.invertSelectionButton.Click += new System.EventHandler(this.invertSelectionButton_Click);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSelectionButton.Location = new System.Drawing.Point(377, 298);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.clearSelectionButton.TabIndex = 85;
            this.clearSelectionButton.Text = "Clear";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // selectByBoxButton
            // 
            this.selectByBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectByBoxButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectByBoxButton.Location = new System.Drawing.Point(377, 242);
            this.selectByBoxButton.Name = "selectByBoxButton";
            this.selectByBoxButton.Size = new System.Drawing.Size(75, 23);
            this.selectByBoxButton.TabIndex = 84;
            this.selectByBoxButton.Text = "by Box";
            this.selectByBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectByBoxButton.UseVisualStyleBackColor = true;
            this.selectByBoxButton.CheckedChanged += new System.EventHandler(this.selectByBoxButton_CheckedChanged);
            // 
            // selectVisibleByPickButton
            // 
            this.selectVisibleByPickButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectVisibleByPickButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectVisibleByPickButton.Location = new System.Drawing.Point(377, 158);
            this.selectVisibleByPickButton.Name = "selectVisibleByPickButton";
            this.selectVisibleByPickButton.Size = new System.Drawing.Size(75, 23);
            this.selectVisibleByPickButton.TabIndex = 83;
            this.selectVisibleByPickButton.Text = "Vis. by Pick";
            this.selectVisibleByPickButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectVisibleByPickButton.UseVisualStyleBackColor = true;
            this.selectVisibleByPickButton.CheckedChanged += new System.EventHandler(this.selectVisibleByPickButton_CheckedChanged);
            // 
            // selectVisibleByBoxButton
            // 
            this.selectVisibleByBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectVisibleByBoxButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectVisibleByBoxButton.Location = new System.Drawing.Point(377, 186);
            this.selectVisibleByBoxButton.Name = "selectVisibleByBoxButton";
            this.selectVisibleByBoxButton.Size = new System.Drawing.Size(75, 23);
            this.selectVisibleByBoxButton.TabIndex = 82;
            this.selectVisibleByBoxButton.Text = "Vis. by Box";
            this.selectVisibleByBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectVisibleByBoxButton.UseVisualStyleBackColor = true;
            this.selectVisibleByBoxButton.CheckedChanged += new System.EventHandler(this.selectVisibleByBoxButton_CheckedChanged);
            // 
            // selectByPickButton
            // 
            this.selectByPickButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectByPickButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectByPickButton.Location = new System.Drawing.Point(377, 214);
            this.selectByPickButton.Name = "selectByPickButton";
            this.selectByPickButton.Size = new System.Drawing.Size(75, 23);
            this.selectByPickButton.TabIndex = 81;
            this.selectByPickButton.Text = "by Pick";
            this.selectByPickButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectByPickButton.UseVisualStyleBackColor = true;
            this.selectByPickButton.CheckedChanged += new System.EventHandler(this.selectByPickButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.selectByBoxEnclButton);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.invertSelectionButton);
            this.Controls.Add(this.clearSelectionButton);
            this.Controls.Add(this.selectByBoxButton);
            this.Controls.Add(this.selectVisibleByPickButton);
            this.Controls.Add(this.selectVisibleByBoxButton);
            this.Controls.Add(this.selectByPickButton);
            this.Controls.Add(this.changeNatureButton);
            this.Controls.Add(this.model1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private devDept.Eyeshot.Model model1;
        private System.Windows.Forms.Button changeNatureButton;
        private System.Windows.Forms.CheckBox selectByBoxEnclButton;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Button invertSelectionButton;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.CheckBox selectByBoxButton;
        private System.Windows.Forms.CheckBox selectVisibleByPickButton;
        private System.Windows.Forms.CheckBox selectVisibleByBoxButton;
        private System.Windows.Forms.CheckBox selectByPickButton;
    }
}