using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDelegates : MonoBehaviour {
  
  enum State{
    Idle,
    Busy,
    Dead
  }
  
  private State state = State.Idle;
  
  private Action attackFunction;
  
  private void Start() {
    attackFunction = PunchAttack;
  }
  
  private void Update() {
    switch (state) {
    default:
    case State.Idle:
      HandleMovement();
      HandleAttack();
      break;
    case State.Busy:
      HandleAttack();
      break;
    case State.Dead:
      break;
    }
  }
  
  private void SetUseSword() {
    attackFunction = SwordAttack;
  }
  
  private void HandleAttack() {
    if (Input.GetMouseButtonDown(0)) {
      attackFunction();
    }
  }
  
  private void PunchAttack(){
    
  }
  
  private void SwordAttack(){
  
  }
  
  private void HandleMovement(){
    
  }
    
}
