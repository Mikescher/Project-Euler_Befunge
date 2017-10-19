/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
long x0=1000;
private int _0(){
    sa(1002001);
    sa(1002001-x0);
    sa(1002001-x0-x0);
    sa(1002001-x0-x0-x0);
    sa(1002001-x0-x0-x0-x0);
    sa(1002001-x0-x0-x0-x0-1);
    return 1;
}
private int _1(){
    if(sp()!=0)return 5;else return 2;
}
private int _2(){
    sa(sp()+sp());

    t0=sp();
    sa(sr());

    if(sp()!=0)return 3;else return 4;
}
private int _3(){
    sa(sp()+t0);
    return 2;
}
private int _4(){
    System.out.print(String.valueOf(t0)+" ");
    sp();
    return 6;
}
private int _5(){
    x0-=2;
    sa(sr()-x0);
    sa(sr()-x0);
    sa(sr()-x0);
    sa(sr()-x0);
    sa(sr()-1);
    return 1;
}

public void main(){
    int c=0;
    while(c<6){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
