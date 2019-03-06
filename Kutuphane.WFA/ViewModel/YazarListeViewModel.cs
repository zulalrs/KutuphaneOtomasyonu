namespace Kutuphane.WFA
{
    internal class YazarListeViewModel
    {
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
      
        public override string ToString() => $"{YazarAdi}";
        
    }
}