import { Component, OnInit } from '@angular/core';

import { FriendsService } from './friends.service'
import { Friend } from '../friend/friend.model'

@Component({
  selector: 'fl-friends',
  templateUrl: './friends.component.html'
})
export class FriendsComponent implements OnInit {

  friends : Friend[]

  constructor( private friendsService : FriendsService ) { }

  ngOnInit() {

    this.friendsService.friends()
        .subscribe(friends => this.friends = friends)

  }



}
