import { Component, OnInit, Input } from '@angular/core';
import { Friend } from './friend.model'

@Component({
  selector: 'fl-friend',
  templateUrl: './friend.component.html'
})
export class FriendComponent implements OnInit {

  @Input() friend: Friend

  constructor() { }

  ngOnInit() {
  }

}
