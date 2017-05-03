/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABACNVMuO6yAM/RUmJJsibsHNqwh55g/6A1E60l2wzYpV7r9fmzTNoxl1rKhKiX045hyT/c0MDGIXUaCBYJVz/BGKDxnvVfq9WBjQpm/0Bs1J86oBGCKK"+
                                    "KDcxo6Eco9SnNvuXBTCeVvLVXv1+cy/QSjMKcbvdRHputCqX/C9JkPM/yQVT2VH4/t5LbzGKY26/C4TUMXV50R89ULW1xhgrP1MsaPgbtH3HXlhjj9AYr49QiiGAVU2n"+
                                    "MpMVqqoClA6ld1MOC0CKTREUcSOsQzQGDFWlziWJuKM0agIPtI8T2voBSpKqZnKp0R/QlvoVwwDgHmJIlDla7RpFlokhCGHsrlNsIbR65OyvtwdX+9F1iajwGTDartPJ"+
                                    "WNhA+LM5ZcxfwTCXng7jRAeqopnQ1p3GAa7UywCtJeB7lOL7DAEqR44qOnrxIvJqASSEjwln+vGZJjRu9ZXbI9xCjYmSn3vJkl6KpCROYPGZkST9EQ1BVxA6mtD+XivX"+
                                    "u2aA6j7PBm9Ao+qWCUmSLmh4ZXtfaYYf31NfM1OmVQL7pqCTV11DmaFUQwkP1+0ma9R0bFfaDGu6RNhqVmi6LUKgclL6xf5ktjO7+nCCMeWnmpwTYp2v8tARlw2rHXpc"+
                                    "68ZibYTzOLmTSyNG8S7aDXQisBLOidmdSnhVvUUDov8ULu6FU2Tap6P692hIErbzVb71e8/Pyp/q+K5cx3+VQY0mGAYAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<78&&y<20)?g[y*78+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<78&&y<20)g[y*78+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        gw(0,2,99);
    _1:
        if(gr(0,2)!=1000)goto _2;else goto _47;
    _2:
        t0=gr(0,2)+1;
        t1=gr(0,2)+1;
        gw(0,2,gr(0,2)+1);
        t1%=2;
        t1=(t1!=0)?0:1;

        if((t1)!=0)goto _1;else goto _3;
    _3:
        t0%=5;
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _1;else goto _4;
    _4:
        gw(1,2,3);
    _5:
        t0=gr(1,2)+1;
        gw(1,2,gr(1,2)+1);
        t0-=14;
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _1;else goto _6;
    _6:
        gw(2,2,0);

        if(((gr(0,gr(1,2))-48)+gr(2,2))!=0)goto _8;else goto _7;
    _7:
        t0=gr(2,2)+1;
        gw(2,2,gr(2,2)+1);
        t0-=3;
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _5;else goto _8;
    _8:
        gw(4,2,gr(0,2));
        sa(5);
        sa(gr(5,gr(1,2))-48);
    _9:
        if(sp()!=0)goto _10;else goto _46;
    _10:
        sa(sr());
        sa((tm(gr(4,2),10))+48);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+7L);

        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(4,2,td(gr(4,2),10));
    _11:
        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _12;else goto _45;
    _12:
        sp();
        sa(gr(12,gr(1,2))-48);
        sa(4);
    _13:
        sa(sr()+7);
        sa(gr(1,2));
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _44;else goto _14;
    _14:
        sp();
        sa(sp()*10L);

        sa(sp()+sp());

        sa(sp()*10L);

        sa(sp()+sp());

        sa(sp()*10L);

        sa(sp()+sp());

        sa(sp()*10L);

        sa(sp()+sp());

        sa(sp()*10L);

        sa(sp()+sp());

        sa(sr());
        gw(7,2,sp());

        if(tm(sr(),2)!=0)goto _16;else goto _15;
    _15:
        sp();
        goto _7;
    _16:
        if(tm(sr(),3)!=0)goto _17;else goto _15;
    _17:
        gw(5,2,sp());
        sa(7);
        sa(tm(gr(5,2),7));
    _18:
        if(sp()!=0)goto _19;else goto _15;
    _19:
        if(sr()>(td(gr(5,2),2)))goto _22;else goto _20;
    _20:
        sa(sr()-2);
        sa(gr(5,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}

        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _15;else goto _21;
    _21:
        sa(sp()+6L);

        sa(sr());
        sa(gr(5,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        goto _18;
    _22:
        gw(8,2,1);
        gw(9,2,gr(2,2));
        gw(9,2,gr(9,2)+1);
        gw(4,2,gr(0,2));
        sp();
    _23:
        sa(5);
        sa(gr(5,gr(1,2))-48);
    _24:
        if(sp()!=0)goto _25;else goto _43;
    _25:
        sa(sr());
        sa((tm(gr(4,2),10))+48);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+7L);

        sa(gr(9,2)+4);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(4,2,td(gr(4,2),10));
    _26:
        sa(sr());

        if(sp()!=0)goto _42;else goto _27;
    _27:
        sp();
        sa(gr(12,gr(9,2)+4)-48);
        sa(4);
    _28:
        sa(sr()+7);
        sa(gr(9,2)+4);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _41;else goto _29;
    _29:
        sp();
        sa(sp()*10L);

        sa(sp()+sp());

        sa(sp()*10L);

        sa(sp()+sp());

        sa(sp()*10L);

        sa(sp()+sp());

        sa(sp()*10L);

        sa(sp()+sp());

        sa(sp()*10L);

        sa(sp()+sp());


        if(tm(sr(),2)!=0)goto _34;else goto _30;
    _30:
        sp();

        if(gr(9,2)!=9)goto _31;else goto _32;
    _31:
        gw(9,2,gr(9,2)+1);
        gw(4,2,gr(0,2));
        goto _23;
    _32:
        if(gr(8,2)!=8)goto _7;else goto _33;
    _33:
        System.Console.Out.Write(gr(7,2));
        return;
    _34:
        if(tm(sr(),3)!=0)goto _35;else goto _30;
    _35:
        gw(5,2,sp());
        sa(7);
        sa(tm(gr(5,2),7));
    _36:
        if(sp()!=0)goto _37;else goto _30;
    _37:
        if(sr()>(td(gr(5,2),2)))goto _40;else goto _38;
    _38:
        sa(sr()-2);
        sa(gr(5,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}

        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _30;else goto _39;
    _39:
        sa(sp()+6L);

        sa(sr());
        sa(gr(5,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        goto _36;
    _40:
        gw(8,2,gr(8,2)+1);
        goto _30;
    _41:
        sa(sp()-1L);
        goto _28;
    _42:
        sa(sp()-1L);

        sa(sr());
        sa(gr(1,2));
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        goto _24;
    _43:
        sa(sr());
        sa(gr(9,2)+48);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+7L);

        sa(gr(9,2)+4);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _26;
    _44:
        sa(sp()-1L);
        goto _13;
    _45:
        sa(sp()-1L);

        sa(sr());
        sa(gr(1,2));
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        goto _9;
    _46:
        sa(sr());
        sa(gr(2,2)+48);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+7L);

        sa(gr(1,2));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _11;
    _47:
        return;
}
}
