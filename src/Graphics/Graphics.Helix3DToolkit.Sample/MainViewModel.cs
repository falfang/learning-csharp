using HelixToolkit.Wpf;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Graphics.Helix3DToolkit.Sample
{
    public class MainViewModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainViewModel()
        {
            var modelGroup = new Model3DGroup();

            var meshBuilder = new MeshBuilder(false, false);
            meshBuilder.AddBox(new Point3D(0, 0, 1), 1, 2, 0.5);
            meshBuilder.AddBox(new Rect3D(0, 0, 1.2, 0.5, 1, 0.4));

            MeshGeometry3D mesh = meshBuilder.ToMesh(true);

            Material greenMaterial = MaterialHelper.CreateMaterial(Colors.Green);
            Material redMaterial = MaterialHelper.CreateMaterial(Colors.Red);
            Material blueMaterial = MaterialHelper.CreateMaterial(Colors.Blue);
            Material insideMaterial = MaterialHelper.CreateMaterial(Colors.Yellow);

            modelGroup.Children.Add(new GeometryModel3D { Geometry = mesh, Material = greenMaterial, BackMaterial = insideMaterial });
            modelGroup.Children.Add(new GeometryModel3D { Geometry = mesh, Transform = new TranslateTransform3D(-2, 0, 0), Material = redMaterial, BackMaterial = insideMaterial });
            modelGroup.Children.Add(new GeometryModel3D { Geometry = mesh, Transform = new TranslateTransform3D(2, 0, 0), Material = blueMaterial, BackMaterial = insideMaterial });

            this.Model = modelGroup;
        }

        /// <summary>
        /// モデル情報
        /// </summary>
        public Model3D Model { get; set; }
    }
}
