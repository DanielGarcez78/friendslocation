import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'

import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'

import { Friend } from "../friend/friend.model"

import { FRIEND_API } from '../app.api'

@Injectable()
export class FriendsService {

  constructor(private http: HttpClient){}

  friends(): Observable<Friend[]> {
    return this.http.get<Friend[]>(`${FRIEND_API}/friends`)
  }

  friendById(id: string): Observable<Friend>{
    return this.http.get<Friend>(`${FRIEND_API}/friends/${id}`)
  }

  nearFriends(id: string): Observable<Friend[]>{
    return this.http.get<Friend[]>(`${FRIEND_API}/locator/${id}`)
  }

}
