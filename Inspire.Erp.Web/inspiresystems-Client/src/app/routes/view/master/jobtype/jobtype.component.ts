import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-jobtype',
  templateUrl: './jobtype.component.html',
  styleUrls: ['./jobtype.component.scss']
})
export class JobtypeComponent implements OnInit {

  constructor(private activatedroute: ActivatedRoute) { }
  title: string;

  ngOnInit(): void {
    this.activatedroute.data.subscribe(data => {
      this.title = data.title;
  });
  }

}
