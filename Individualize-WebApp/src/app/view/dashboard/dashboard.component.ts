import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from  '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  public titulo = 'Dashboard';

  constructor(
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {
    const par = this.activatedRoute.snapshot.paramMap.get('parametro');
    console.log(par);
  }

  // goToLogin(){
  //   this.router.navigate(['/login']);
  // }

}
