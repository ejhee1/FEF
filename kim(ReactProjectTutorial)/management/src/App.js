import React, { Component } from 'react';
import Customer from './components/Customer';
import './App.css';

const customers = [
  {
  'id': 1,
  'image': 'https://placeimg.com/64/64/1',
  'name': '김하연',
  'birthday': '990521',
  'gender': '여자',
  'job': '대학생'
  },
  {
    'id': 2,
    'image': 'https://placeimg.com/64/64/2',
    'name': '홍길동',
    'birthday': '960305',
    'gender': '남자',
    'job': '프로그래머'
    },
    {
      'id': 3,
      'image': 'https://placeimg.com/64/64/3',
      'name': '이순신',
      'birthday': '921205',
      'gender': '남자',
      'job': '디자이너'
      }
]

class App extends Component {
  render() {
    return (
      <div>
        {customers.map(c => {  // map 함수: 특정 배열의 원소에 접근이 효과적
          return ( <Customer key={c.id} id={c.id} image={c.image} name={c.name} birthday={c.birthday} gender={c.gender} job={c.job}/>);
        })}
      </div>
    );
  }
}

export default App;
