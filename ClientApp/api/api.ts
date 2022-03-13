export * from './account.service';
import { AccountService } from './account.service';
export * from './admin.service';
import { AdminService } from './admin.service';
export * from './buggy.service';
import { BuggyService } from './buggy.service';
export * from './friends.service';
import { FriendsService } from './friends.service';
export * from './messages.service';
import { MessagesService } from './messages.service';
export * from './movies.service';
import { MoviesService } from './movies.service';
export * from './users.service';
import { UsersService } from './users.service';
export const APIS = [AccountService, AdminService, BuggyService, FriendsService, MessagesService, MoviesService, UsersService];
