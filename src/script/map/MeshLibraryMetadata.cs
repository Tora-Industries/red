using Godot;
using Red.Data.Map;

namespace Red.MapScene
{
    public partial class MeshLibraryMetadata : Resource
    {
        [Export]
        private Godot.Collections.Array<TileAttribute> _attributes = new();
        [Export]
        private Godot.Collections.Array<TileSubAttribute> _subAttributes = new();
        [Export]
        private Godot.Collections.Array<int> _intrinsicHeights = new();
        [Export]
        private Godot.Collections.Array<float> _floorHeights = new();
        
        public (TileAttribute, TileSubAttribute, int, float) GetItemMetadata(int id)
        {
            return (_attributes[id], _subAttributes[id], _intrinsicHeights[id], _floorHeights[id]);
        }

        void SetItemMetadata(int id, TileAttribute attr, TileSubAttribute subAttr, int intrinsicHeight, float floorHeight)
        {
            _attributes[id] = attr;
            _subAttributes[id] = subAttr;
            _intrinsicHeights[id] = intrinsicHeight;
            _floorHeights[id] = floorHeight;
        }
    }
}