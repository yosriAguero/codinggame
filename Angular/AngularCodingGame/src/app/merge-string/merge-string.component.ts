import { Component, output } from '@angular/core';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-merge-string',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './merge-string.component.html',
  styleUrl: './merge-string.component.css'
})
export class MergeStringComponent {
  wordone!: string ;
  wordtwo!: string ;
  result!:string;
signIn() {

this.result = mergeString(this.wordone,this.wordtwo);

}
}
export function mergeString(word1: string, word2: string) : string{

  const len1 =  word1.length;
const len2 = word2.length;
const lenMin = Math.min(len1,len2);
 let result = '';

for(var i = 0; i < lenMin ; i++)
  {
    result += word1[i];
    result += word2[i];
  }

if(len1 > len2)
  {
    result += word1.substring(lenMin);
  }
  else{
    result += word2.substring(lenMin);
  }
  return result;


}
