/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3/fMvG0iwP1iftOvdpIwrZdu8TVxjdhQ/CZjKNUNpoaIOi+3HhxvLJZhD/jmbf7NpN9koo20bsf963mbus1mi8/bUfn716OjuDz/+"+
                                 "Pj16u+DSuvnxcXv4NNkZGB5s6GMYbOCHOtOB8zdaAx5dWG7J9/XJlrlzrj0T+pVoenyL3br2jVu38j1vr4vaYb7s6OmjNyPv92pOS5wofndG8sskncqOVEGxZBkvqVNn"+
                                 "o8vieyZkna+Qyp6vyVO4Tvns8ddVEbx/Y9wtOA3Pba2VlpN5O6921/vD+39UOfzIuvSv43zzj5vPMqIfV/YZzsn/drdo7qfqdsZ/8zR15unt63kYtP5wCH+tRLTU+u3h"+
                                 "tdky+tHZr45LPYx/vq2lbXdacN66VdfXtq0X3GO+qbmlzfqNuNdv/19bTP4+nDbz2JXnV02OhbSFBHmp+j1OV/1lUWZ49nbUkeVzTpnwZcbJx9+//+1W0KziWbuvtM24"+
                                 "3Fkk927O64r9p176eh7Osl2eqKP5vTQq/SPv9pvzmP4eO3J36pxzu22Wb4mZl7/Obp/9mk5+drOnE4L1LJ8HZX+r+fNWqdqr8lzlu1v97+5uyz2wfN/W5fejDjOzf1d+"+
                                 "/bp2puzbwwffXv728NZFO5k74W+3Tp/9u8D6d8GH+zevtO6ptdgRv+zppms/Y+Nsa0peuDN++3Xtf8T/Gamd6epvVUMv8rV/EJzH6jhBYAYTAwDFa1uflwIAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[170000];for(int i=0;i<170000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<1000&&y<170)?g[(int)(y*1000+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<1000&&y<170)g[(int)(y*1000+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(1,0,1000);
    gw(2,0,150);
    gw(0,0,150000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
    return 1;
}
private int _1(){
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 34;else return 3;
}
private int _3(){
    sp();
    return 4;
}
private int _4(){
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    return 5;
}
private int _5(){
    if((t0)!=0)return 6;else return 4;
}
private int _6(){
    if(gr(0,0)>gr(3,0))return 1;else return 7;
}
private int _7(){
    gw(3,0,1);
    gw(4,0,0);
    return 8;
}
private int _8(){
    t0=gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3)-32;

    if(gr(0,0)<=gr(3,0))return 9;else return 31;
}
private int _9(){
    gw(5,0,gr(4,0)-1);
    gw(1,2,2);
    gw(2,2,2);
    sa(2);
    return 10;
}
private int _10(){
    sa(sr()+1);
    sa(sr());
    gw(0,1,sp());
    gw(3,1,sp());
    gw(1,1,1);
    sa(0);
    sa(gr(0,3));
    sa((gr(0,3)*gr(0,3))>gr(0,1)?1:0);
    return 11;
}
private int _11(){
    if(sp()!=0)return 30;else return 12;
}
private int _12(){
    gw(2,1,1);
    return 13;
}
private int _13(){
    sa(sr());
    t0=gr(3,1);
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 29;else return 14;
}
private int _14(){
    gw(1,1,gr(1,1)*gr(2,1));

    if(gr(3,1)!=1)return 15;else return 16;
}
private int _15(){
    sp();
    sa(sp()+1L);

    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa((sp()>gr(0,1))?1:0);
    return 11;
}
private int _16(){
    gw(2,2,gr(1,1));
    sp();
    sp();
    return 17;
}
private int _17(){
    if((gr(1,2)*gr(2,2))>500)return 28;else return 18;
}
private int _18(){
    sa(sp()+1L);


    if(tm(sr(),2)!=0)return 19;else return 10;
}
private int _19(){
    sa(td(sr()+1,2));
    sa(sr());
    gw(0,1,sp());
    gw(3,1,sp());
    gw(1,1,1);
    sa(0);
    sa(gr(0,3));
    sa((gr(0,3)*gr(0,3))>gr(0,1)?1:0);
    return 20;
}
private int _20(){
    if(sp()!=0)return 27;else return 21;
}
private int _21(){
    gw(2,1,1);
    return 22;
}
private int _22(){
    sa(sr());
    t0=gr(3,1);
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 26;else return 23;
}
private int _23(){
    gw(1,1,gr(1,1)*gr(2,1));

    if(gr(3,1)!=1)return 24;else return 25;
}
private int _24(){
    sp();
    sa(sp()+1L);

    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa((sp()>gr(0,1))?1:0);
    return 20;
}
private int _25(){
    gw(1,2,gr(1,1));
    sp();
    sp();
    return 17;
}
private int _26(){
    gw(2,1,gr(2,1)+1);
    sa(sr());
    t0=gr(3,1);
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(td(sp(),v0));}

    t1=sp();
    gw(3,1,t1);
    return 22;
}
private int _27(){
    gw(1,2,gr(1,1)*2);
    sp();
    sp();
    return 17;
}
private int _28(){
    t0=sr()+1;
    sa(sp()*t0);

    t1=sp();
    t1/=2;
    System.out.print(String.valueOf(t1)+" ");
    return 35;
}
private int _29(){
    gw(2,1,gr(2,1)+1);
    sa(sr());
    t0=gr(3,1);
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(td(sp(),v0));}

    t1=sp();
    gw(3,1,t1);
    return 13;
}
private int _30(){
    gw(2,2,gr(1,1)*2);
    sp();
    sp();
    return 17;
}
private int _31(){
    if((t0)!=0)return 32;else return 33;
}
private int _32(){
    gw(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3,gr(3,0));
    gw(4,0,gr(4,0)+1);
    gw(3,0,gr(3,0)+1);
    return 8;
}
private int _33(){
    gw(3,0,gr(3,0)+1);
    return 8;
}
private int _34(){
    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(0,0)?1:0);
    return 2;
}

public void main(){
    int c=0;
    while(c<35){
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
    case 13:c=_13();break;
    case 14:c=_14();break;
    case 15:c=_15();break;
    case 16:c=_16();break;
    case 17:c=_17();break;
    case 18:c=_18();break;
    case 19:c=_19();break;
    case 20:c=_20();break;
    case 21:c=_21();break;
    case 22:c=_22();break;
    case 23:c=_23();break;
    case 24:c=_24();break;
    case 25:c=_25();break;
    case 26:c=_26();break;
    case 27:c=_27();break;
    case 28:c=_28();break;
    case 29:c=_29();break;
    case 30:c=_30();break;
    case 31:c=_31();break;
    case 32:c=_32();break;
    case 33:c=_33();break;
    case 34:c=_34();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
