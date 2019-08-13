using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using Maps.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GMapControl1_Load(object sender, EventArgs e)
        {
            //Настройки для компонента GMap.
            gMapControl1.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту 
            ///с помощью правой кнопки мыши. 
            gMapControl1.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется 
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.GrayScaleMode = true;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControl1.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            gMapControl1.MaxZoom = 18;

            //Указываем значение минимального приближения.
            gMapControl1.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControl1.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            gMapControl1.NegativeMode = false;

            //Разрешаем полигоны.
            gMapControl1.PolygonsEnabled = true;

            //Разрешаем маршруты
            gMapControl1.RoutesEnabled = true;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControl1.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться 
            //18ти кратное приближение.
            gMapControl1.Zoom = 5;

            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются 
            //соответствующим образом.
            gMapControl1.Dock = DockStyle.Fill;

            //Указываем что будем использовать карты Google.
            gMapControl1.MapProvider =
            GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode =
                GMap.NET.AccessMode.ServerOnly;

            //Если вы используете интернет через прокси сервер,
            //указываем свои учетные данные.
            GMap.NET.MapProviders.GMapProvider.WebProxy =
                System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials =
                System.Net.CredentialCache.DefaultCredentials;

          
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddMarker().Show();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаем новый список маркеров, с указанием компонента 
            //в котором они будут использоваться и названием списка
            GMap.NET.WindowsForms.GMapOverlay markersOverlay =
                new GMap.NET.WindowsForms.GMapOverlay();

            


            //Инициализация нового КРАСНОГО маркера, с указанием его координат
            //GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markerR =
            //    new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(
            //    new GMap.NET.PointLatLng(55.75393, 37.620695));
            //markerR.ToolTip =
            //    new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerR);
            //Текст отображаемый при наведении на маркер
            //markerR.ToolTipText = "Красная площадь";

            //Добавляем маркеры в список маркеров
            
            //markersOverlay.Markers.Add(markerR);
            //Добавляем в компонент, список маркеров 
            using (EventContext context = new EventContext())
            {
                foreach (var item in context.Events)
                {
                    GMarkerGoogle markerG = new GMarkerGoogle(new PointLatLng(item.Latitude, item.Longitude), GMarkerGoogleType.blue_dot);
                    markerG.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);
                    //Текст отображаемый при наведении на маркер
                   
                    markerG.ToolTipText = item.Name+"\n"+item.Year;
                   
                    markersOverlay.Markers.Add(markerG);
                }
            }
            gMapControl1.Overlays.Add(markersOverlay);

        }
    }
}
