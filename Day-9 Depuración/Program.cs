static void Fiesta(){
    var friends = new List<string> {"María","Ana","Martina","Juan","Leonardo","Carlos","Marianela"};
    var friendsParty = ObtainFriendsParty(friends,3);

    foreach(var name in friendsParty)
        Console.WriteLine(name);
    Console.ReadKey();
}

static List<string> ObtainFriendsParty(List<string> lista, int cuenta){
    var friendsParty = new List<string>();

    while(friendsParty.Count < cuenta){
        var currentFriend = ObtainFriendParty(lista);
        friendsParty.Add(currentFriend);
        lista.Remove(currentFriend);
    }
    return friendsParty;
}

static string ObtainFriendParty(List<string> lista){
    string shorterName = lista[0];

    for(var i = 0; i < lista.Count;i++){
        if(lista[i].Length > shorterName.Length){
            shorterName=lista[i];
        }
    }
    return shorterName;
}

Fiesta();