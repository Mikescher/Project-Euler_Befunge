/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADlmM1uIzcQhF+lIWcvGjjmP4eCoAR5DsPOba466bQPv1+1tJtdIM5KCJhLiLFEzlBgTXV1NemLfd8u9kg7PjT7oXbalV16OezjcwhnO1kIYTuY37RP"+
                                 "u992y+tt8BIXO5vp8XWuPb29X5YP2zzId7T/G6ywWkiWko1uebVYiZOVoM9Ov1jgs1tfrSaLySr3u42oH34WrKe/af8eVhm6xhCU2G2NFkHQrQVbu+5wf6xWsjXmrAJa"+
                                 "m7Uk3BNhgQNYOVrPVqv1YbFYAmi2HoWpdavZ1tUyFGZNjtkyyOpMWISmw0e1lMUEJEXQJHGTGK7iJkTLSR2A5q6gA4s4ToSFqqAq+pI1ipsGN8Qr2vDla9Gc4oJLq7Vm"+
                                 "OYuwdWoQoaR0kQFPKExhquKjFEkeBEQQvYNvBV+wXCW4q/YnwgIQikZhYqIolBAWIaYpMW/aGuKMWEMVCZF9Zp8Ki1VBAA3NnaK5CyRXG9EcxfJQJzhE9AQyZS4vMFdb"+
                                 "RQlYV/kTS5KPhBKgw92B8HENIpiVocrHIuUBtKepsKJ0ozQc7p+4ZZOwIAyRSUlFN1uUzmS5RSmi/lSDgIzozoS2yDjJ3PMRuydSwTNOxpGUrYI4NBmzGFPZYjHUQwTx"+
                                 "KoKVHRa5eY0sUUvOlqAX9UXtsLWqEsx0+eaGGVRYwIR7IR2KoIAWXfhncZsl3ADF28AnlFNrYhwKEwbRXPXDbUwWv7r8kztn8zrdVaSDSx4uy1SDUOlNyv/1quiqTCSy"+
                                 "EMawutMyTH5RMRF76rI60nZmEN3BoWp1EM1Ni+SX3XudQf50oAc/UzHIquLVNxRz2SrOByHDvlNVBlCtUTcBBR+2Li91pWcvjkDHRPJUtuTvQ2tQmwHB7iXlm22yPAHl"+
                                 "6ZpuJYgE7EVvwvw4G5Z4qiJDJZmNQ9BOprttUme061ql+tU3GoCunqfk48wgRhVdVeIo1V/zv7nqtbHJwoTFsztVZrh9kLwS3EyDuJxDeI77w55KQzvHZYm1hnPw78i4"+
                                 "1ueosY+G9+GTqSGG44NHjBO/vussetLBr5b9p7yPyyudl7Jsu7B7rmm//+tZ+uHZ8vXB4+fE0y+nKx3/DOvzPdjVnNXDxsF1KS9w+7rs/tg9ytbb+9vTn1uIh+MH2L4e"+
                                 "1E+89O1MfUpJH2EbyyFsOZzjVojYjRgCK74aX2ED0dLCBnlVM7eFpxrTY8LppzMupnU4nrPi0+X921Gdg3oM26/2+/evwh9vcy99H7Yjem3LFsoW2jlUenkLdVs0FsUM"+
                                 "jm/i5UpWmPivjB/az9na7/dv/xGYb+3uBY8f8/QFUdxTbEkSAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[4681];for(int i=0;i<4681;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<151&&y<31)?g[(int)(y*151+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<151&&y<31)g[(int)(y*151+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2,t3;
private int _0(){
    gw(0,0,675);
    return 1;
}
private int _1(){
    gw((gr(0,0)%26)+63,(gr(0,0)/26)+1,0);
    t0=gr(0,0);
    gw(0,0,gr(0,0)-1);
    return 2;
}
private int _2(){
    if((t0)!=0)return 1;else return 3;
}
private int _3(){
    gw(1,0,0);
    gw(9,0,0);
    gw(9,1,-1);
    gw(10,0,1);
    gw(10,1,-1);
    gw(11,0,1);
    gw(11,1,0);
    gw(0,0,399);
    return 4;
}
private int _4(){
    gw((gr(0,0)%20)+66,(gr(0,0)/20)+4,((gr(((gr(0,0)%20)*3)+1,(gr(0,0)/20)+4)-48)*10)+(gr(((gr(0,0)%20)*3)+2,(gr(0,0)/20)+4)-48));
    t0=gr(0,0);
    gw(0,0,gr(0,0)-1);
    return 5;
}
private int _5(){
    if((t0)!=0)return 4;else return 6;
}
private int _6(){
    gw(0,0,399);
    return 7;
}
private int _7(){
    gw(2,0,2);
    return 8;
}
private int _8(){
    sa(gr(2,0)+9);
    gw(3,0,gr(gr(2,0)+9,0));
    sa(1);
    {long v0=sp();t0=gr(sp(),v0);}
    gw(4,0,t0);
    t0=gr(0,0)/20;
    gw(5,0,gr(0,0)%20);
    gw(6,0,t0);
    t0=gr(gr(5,0)+66,gr(6,0)+4);
    gw(5,0,gr(5,0)+gr(3,0));
    gw(6,0,gr(6,0)+gr(4,0));
    t1=gr(gr(5,0)+66,gr(6,0)+4);
    gw(5,0,gr(5,0)+gr(3,0));
    gw(6,0,gr(6,0)+gr(4,0));
    t2=gr(gr(5,0)+66,gr(6,0)+4);
    gw(5,0,gr(5,0)+gr(3,0));
    gw(6,0,gr(6,0)+gr(4,0));
    t2*=gr(gr(5,0)+66,gr(6,0)+4);
    gw(5,0,gr(5,0)+gr(3,0));
    gw(6,0,gr(6,0)+gr(4,0));
    t3=t1*t2;
    t1=t0*t3;

    if(t1>gr(1,0))return 12;else return 9;
}
private int _9(){
    t0=gr(2,0);
    gw(2,0,gr(2,0)-1);

    if((t0)!=0)return 8;else return 10;
}
private int _10(){
    t0=gr(0,0);
    gw(0,0,gr(0,0)-1);

    if((t0)!=0)return 7;else return 11;
}
private int _11(){
    System.out.print(String.valueOf(gr(1,0))+" ");
    return 13;
}
private int _12(){
    gw(1,0,t1);
    return 9;
}

public void main(){
    int c=0;
    while(c<13){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
    case 6:c=_6();break;
    case 7:c=_7();break;
    case 8:c=_8();break;
    case 9:c=_9();break;
    case 10:c=_10();break;
    case 11:c=_11();break;
    case 12:c=_12();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
