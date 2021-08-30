namespace UAssetAPI
{
    public class Link
    {
        public ulong Base;
        public ulong Class;
        public int Linkage;
        public int Property;
        public int Target;
        public int Index;

        public Link(string bbase, string bclass, int link, string property, AssetReader asset, int index = 0, int target = 0)
        {
            Base = (ulong)asset.SearchHeaderReference(bbase);
            Class = (ulong)asset.SearchHeaderReference(bclass);
            Linkage = link;
            Property = asset.SearchHeaderReference(property);
            Index = index;
            Target = target;
        }

        public Link(ulong bbase, ulong bclass, int link, int property, int index = 0, int target = 0)
        {
            Base = bbase;
            Class = bclass;
            Linkage = link;
            Property = property;
            Index = index;
            Target = target;
        }

        public Link()
        {

        }
    }
}
