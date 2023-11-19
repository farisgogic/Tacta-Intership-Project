import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShoppersListsComponent } from './shoppers-lists.component';

describe('ShoppersListsComponent', () => {
  let component: ShoppersListsComponent;
  let fixture: ComponentFixture<ShoppersListsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShoppersListsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShoppersListsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
