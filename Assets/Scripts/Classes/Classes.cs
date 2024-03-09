 using System.Collections.Generic;

 public class ColorExterior
 {
     public string color_name;
     public List<DetailColor> detail_color;
 }

 public class ColorInterior
 {
     public string color_name;
     public List<DetailColor> detail_color;
 }

 public class DetailColor
 {
     public string hexcode;
     public string type;
 }

 public class LentsColor
 {
     public string color_name;
     public List<DetailColor> detail_color;
 }

 public class RimsColor
 {
     public string color_name;
     public List<DetailColor> detail_color;
 }

 public class Root
 {
     public string car_name;
     public List<RimsColor> rims_color;
     public List<ColorExterior> color_exterior;
     public List<ColorInterior> color_interior;
     public List<LentsColor> lents_color;
 }
 [System.Serializable]
 public class HexColor
 {
     public string hexcode;
     public string type;
 }

