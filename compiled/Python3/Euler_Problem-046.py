#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADt2k1Lw0AQBuC/st20l4S4k020zVAWL5716CGkRS0LoriI7qk/3lk/oNraFooo8j6wgelMs5uZ5taYJSotY9TF48Pt4vpJnT3fLR5VmeKru8W9ak7U"
  + "H5cBAAAAAAAAAAAAAAAAAAAAAAAA/AO/+V88Z3cUxNViii5GFagtPLW55UDjsvM0TiFPf/Kcn84Risp4qrqRXLjT53qqhvHbb75ZPV17GsIkU9E0HxnHLfliTH4+UEun"
  + "b7TNuaKgrWZLIW8o2JrCrj3eOJJSVR/LZVP2mLwtWLIsO/hRJxdTFV4rXWb9rHdVSvpykMXZesVASlK6K61h6o/G5Mg7TgeXjOMlm0bGY6wMZBoDTfJJnjOnNQlVFSpi"
  + "uc1ek5r12dxT7anZWN7v1YvXJ95d0rteOZmANS2FxkgwlIjzUpoQldOXupZwpRlBYier4EaaMX+/jVQP06fSQhnBWvOWm7Ye7jra3s+51ZaW919+zkqnV2nLvgfO40BT"
  + "9QKcPtfBiCwAAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<200 and y<57):
        return g[y*200 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<200 and y<57):
        g[y*200 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(1,0,200)
    gw(2,0,50)
    gw(4,0,10000)
    gw(3,0,2)
    return 1
def _1():
    gw(0,1,32)
    gw(1,1,32)
    gw(8,0,1073741824)
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(4,0))else(0))
    return 2
def _2():
    return (25)if(sp()!=0)else(3)
def _3():
    sp();
    return 4
def _4():
    global t0
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+1);

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    return 5
def _5():
    global t0
    return (6)if((t0)!=0)else(4)
def _6():
    return (1)if(gr(4,0)>gr(3,0))else(7)
def _7():
    gw(3,0,0)
    gw(5,0,3)
    return 8
def _8():
    global t0
    sa(gr(5,0)+2)
    gw(5,0,gr(5,0)+2)
    sa(sr());
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+1);

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32

    return (9)if((t0)!=0)else(10)
def _9():
    sa(79)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+1);

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 8
def _10():
    sp();
    sa(3)
    sa((0)if(3-gr(5,0)!=0)else(1))
    return 11
def _11():
    return (24)if(sp()!=0)else(12)
def _12():
    global t0
    sa(sr());
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+1);

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    t0=(0)if(t0!=0)else(1)

    return (18)if((t0)!=0)else(13)
def _13():
    global t0
    sa(sr());
    t0=gr(5,0)
    gw(9,0,0)
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    sa(td(sp(),2))

    sa(sr());
    gw(7,0,sp())
    sa(gr(8,0))
    sa((1)if(gr(8,0)>gr(7,0))else(0))
    return 14
def _14():
    return (23)if(sp()!=0)else(15)
def _15():
    sa(sr());
    return 16
def _16():
    return (20)if(sp()!=0)else(17)
def _17():
    sp();
    sa(sp()-(gr(9,0)*gr(9,0)));


    return (18)if(sp()!=0)else(19)
def _18():
    sa(sp()+1);

    sa((0)if(sr()-gr(5,0)!=0)else(1))
    return 11
def _19():
    sp();
    return 8
def _20():
    return (22)if((sr()+gr(9,0))<=gr(7,0))else(21)
def _21():
    gw(9,0,td(gr(9,0),2))
    sa(td(sp(),4))

    sa(sr());
    return 16
def _22():
    global t0
    global t1
    global t2
    t0=sr()+gr(9,0)
    t1=gr(7,0)
    t2=t1-t0
    gw(7,0,t2)
    t0=(sr()*2)+gr(9,0)
    gw(9,0,t0)
    gw(9,0,td(gr(9,0),2))
    sa(td(sp(),4))
    return 15
def _23():
    sa(td(sp(),4))

    sa((1)if(sr()>gr(7,0))else(0))
    return 14
def _24():
    print(sp(),end=" ",flush=True)
    return 26
def _25():
    sa(sr());
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+1);

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(3,0));

    sa((1)if(sr()<gr(4,0))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25]
c=0
while c<26:
    c=m[c]()
