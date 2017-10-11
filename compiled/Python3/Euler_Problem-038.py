#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADNkDtvxCAMgP8KSegSmivOY6iFrFs6V8qMckNVsTIx8eNrSKqQi3Tq1PYbjJ/4EZpvxP8mHAYNfz3OEbNez8M4GXG+aDGtAlPUHdYw57WMuCf43mrc"
  + "/RR2uXlkMoJ1PZ7LS6j+/KjbATz1IwsNHRAO4FqLI7iuWW6SLGjPAUs4TerJsnjBHADt2GgVxxFUcrHHJjXcZEomIaDDyG1yKUbC3lWRwPY+f1NFQTkvpVEq466s8yyQ"
  + "mg/Z4vHiwy1Wlh/k3GHL60iSuP0hm12umKA25OOL/iZSUn6pcGl67Sors7EIumTlmuVzQtTz+zy/1eYL/qbl3PYDAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<169 and y<6):
        return g[y*169 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<169 and y<6):
        g[y*169 + x]=v;
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
    gw(3,1,9999)
    gw(4,1,2)
    return 1
def _1():
    sa(-1)
    sa(gr(3,1))
    sa(1)
    sa(1-gr(4,1))
    return 2
def _2():
    return (30)if(sp()!=0)else(3)
def _3():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 4
def _4():
    gw(1,0,sp())
    sa(-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 5
def _5():
    sa(tm(sr(),10))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))

    sa(sr());
    return 6
def _6():
    return (5)if(sp()!=0)else(7)
def _7():
    sp();
    return 8
def _8():
    sa(sp()+(gr(1,0)*10));

    gw(1,0,sp())
    return 9
def _9():
    return (8)if((sr()+1)!=0)else(10)
def _10():
    sp();
    sa(gr(1,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (4)if((sr()+1)!=0)else(11)
def _11():
    sp();
    sa(sr());
    sa(9)
    return 12
def _12():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr());
    return 13
def _13():
    return (12)if(sp()!=0)else(14)
def _14():
    sp();
    sa(sr());
    return 15
def _15():
    sa(tm(sr(),10))
    sa(sr());

    return (16)if(sp()!=0)else(28)
def _16():
    sa(sr());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))

    return (17)if(sp()!=0)else(28)
def _17():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (18)if(sp()!=0)else(15)
def _18():
    sp();
    sa(9)
    return 19
def _19():
    sa(sr());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);

    sa(sr());
    return 20
def _20():
    return (19)if(sp()!=0)else(21)
def _21():
    sp();
    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()-9);

    sa((0)if(sp()!=0)else(1))
    return 22
def _22():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sp();

    return (27)if(sp()!=0)else(23)
def _23():
    sp();
    sa(gr(4,1)-1)
    gw(4,1,gr(4,1)-1)
    sa(sp()-1);


    return (1)if(sp()!=0)else(24)
def _24():
    sa(gr(3,1)-1)
    gw(3,1,gr(3,1)-1)

    return (26)if(sp()!=0)else(25)
def _25():
    print("RORRE",end="",flush=True)
    return 31
def _26():
    gw(4,1,5)
    return 1
def _27():
    print(sp(),end=" ",flush=True)
    return 31
def _28():
    sp();
    return 29
def _29():
    sp();
    sa(0)
    return 22
def _30():
    sa(sp()+1);

    sa(sr()*gr(3,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr()-gr(4,1))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30]
c=0
while c<31:
    c=m[c]()
