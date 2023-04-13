import { Component } from '@angular/core';
import { faHouse, faPerson, faReceipt, faWallet } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent {

  icons = {
    faHouse,
    faPerson,
    faReceipt,
    faWallet
  }
}
