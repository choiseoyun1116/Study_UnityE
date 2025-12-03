using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class RenpyStoryData
{
  [SerializeField]
  int id;
  public int ID { get {return id; } set { this.id = value;} }
  
  [SerializeField]
  int bg;
  public int BG { get {return bg; } set { this.bg = value;} }
  
  [SerializeField]
  int character;
  public int Character { get {return character; } set { this.character = value;} }
  
  [SerializeField]
  int text;
  public int Text { get {return text; } set { this.text = value;} }
  
  [SerializeField]
  int[] image_l = new int[0];
  public int[] Image_L { get {return image_l; } set { this.image_l = value;} }
  
  [SerializeField]
  int[] image_lm = new int[0];
  public int[] Image_LM { get {return image_lm; } set { this.image_lm = value;} }
  
  [SerializeField]
  int[] image_m = new int[0];
  public int[] Image_M { get {return image_m; } set { this.image_m = value;} }
  
  [SerializeField]
  int[] image_rm = new int[0];
  public int[] Image_RM { get {return image_rm; } set { this.image_rm = value;} }
  
  [SerializeField]
  int[] image_r = new int[0];
  public int[] Image_R { get {return image_r; } set { this.image_r = value;} }
  
}