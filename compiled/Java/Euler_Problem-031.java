/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABAClUUFqxDAQ+4pJ9zQmRRpvdjfBmD6khB4Kc52TT3l8nW4CbSGFbnWwPTPIkuX6tCP8HY+x/o2CHYQrPMHP8AF+gV/hN/gID6F771RCIH1UOhI9oNaH"+
                                 "VU/5W1kdTp0ijYo2KqaDSLzCBok3mEocYXHXK0qDMa6br8XYb5OlsHGaWRFttM9DbGuqZSLt9W3x4yTmMF+iyHkwDFE67QznKIZcN7cztWc+vOD+lG2+e81Lb2S4d5df"+
                                 "iD2nvBimFkF2pjWL9FWrnBLt+eXYPvv2M2H+0f4AZyRUOpQCAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[660];for(int i=0;i<660;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<60&&y<11)?g[(int)(y*60+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<60&&y<11)g[(int)(y*60+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(1,0,0);
    gw(2,0,0);
    gw(3,0,0);
    gw(4,0,0);
    gw(5,0,0);
    gw(6,0,0);
    gw(7,0,0);
    gw(8,0,0);
    gw(9,0,0);
    gw(1,1,200);
    gw(2,1,9);
    gw(3,1,0);
    gw(gr(2,1),0,gr(gr(2,1),0)+1);
    return 1;
}
private int _1(){
    if(gr(2,1)!=9)return 11;else return 2;
}
private int _2(){
    t0=(gr(1,0)*500)+(gr(2,0)*200)+(100*gr(3,0))+(gr(4,0)*50)+(gr(5,0)*20)+(gr(6,0)*10)+(gr(7,0)*5)+(gr(8,0)*2)+gr(9,0);

    if(((gr(1,0)*500)+(gr(2,0)*200)+(100*gr(3,0))+(gr(4,0)*50)+(gr(5,0)*20)+(gr(6,0)*10)+(gr(7,0)*5)+(gr(8,0)*2)+gr(9,0))<gr(1,1))return 10;else return 3;
}
private int _3(){
    t0-=gr(1,1);

    if((t0)!=0)return 4;else return 9;
}
private int _4(){
    t0=gr(2,1);

    if((gr(gr(2,1),0))!=0)return 6;else return 5;
}
private int _5(){
    t0--;
    gw(2,1,t0);
    return 4;
}
private int _6(){
    if(t0!=1)return 8;else return 7;
}
private int _7(){
    System.out.print(String.valueOf(gr(3,1))+" ");
    return 12;
}
private int _8(){
    t0--;
    gw(2,1,t0);
    gw(gr(2,1),0,gr(gr(2,1),0)+1);
    return 1;
}
private int _9(){
    gw(3,1,gr(3,1)+1);
    return 4;
}
private int _10(){
    gw(gr(2,1),0,gr(gr(2,1),0)+1);
    return 1;
}
private int _11(){
    sa(0);
    sa(gr(2,1)+1);
    gw(2,1,gr(2,1)+1);
    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 1;
}

public void main(){
    int c=0;
    while(c<12){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
