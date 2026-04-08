namespace knightmoves;
using static StateList;
public class StateLookUp{

    public IEnumerable<string> LookUp(string search){
        var matches = new List<string>();

        var LINQmatches = from state in STATES 
                          where state.StartsWith(search) 
                          orderby state ascending
                          select state;
        return LINQmatches;
    }
}
