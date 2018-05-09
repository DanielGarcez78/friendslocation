import {Routes} from '@angular/router'

import { HomeComponent } from './home/home.component'
import { FriendsComponent } from './friends/friends.component'
import { FriendVisitComponent } from './friend-visit/friend-visit.component'

export const ROUTES: Routes = [
  { path: '', component: HomeComponent },
  { path: 'friends', component: FriendsComponent },
  { path: 'friend-visit/:id', component: FriendVisitComponent }
]
