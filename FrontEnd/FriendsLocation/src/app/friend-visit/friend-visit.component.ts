import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';


import { Friend } from '../friend/friend.model'
import { FriendsService } from '../friends/friends.service'

@Component({
  selector: 'fl-friend-visit',
  templateUrl: './friend-visit.component.html'
})
export class FriendVisitComponent implements OnInit {

  friendVisited : Friend

  friends : Friend[]

  constructor(private friendsService : FriendsService,
              private route: ActivatedRoute ) { }

  ngOnInit() {

    this.friendsService.friendById(this.route.snapshot.params['id'])
        .subscribe(friendVisited => this.friendVisited = friendVisited)

    this.friendsService.nearFriends(this.route.snapshot.params['id'])
        .subscribe(friends => this.friends = friends)

  }

}
