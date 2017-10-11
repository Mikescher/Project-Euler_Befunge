#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhrfX7+Y1GUgc+xi9UnPelsRLfDL7FM/qLbl4eF7REUHx/YtuLuuOvuN+6ENlHTsXC+/J+/seLOBaytmfVOHDw++VWhzPfLZBW07kcPOj"
  + "FexHPyyQADGTKgJ4+LseOhraaLTRSnCK1JWzfM1xnvs9t/aHlW6v7/s3/4LG/W+XrwVnlz3bOCXz9vXjzrevzSmbfa/j/jetHUGrNPb5va6yv+96+T1v/Lo7B3dttl33"
  + "0Tqo9vGdjT5T0//+FpgjKjhZfef7UNHl0v8EvJfverB6H9enDL/mu27xq7d4Gp2rPfpFvWv72oNmvSWKuzYYB7rtrPpVHCjC//JLRfj6z7Mjvv8SncN6WuRa4Je6K7P/"
  + "MHe4pq+fY7jXR/nAPv/GP8onjA9vXxlTKKYTpDGlz/G56vqpGdU/3iy0lRCs36P8RZz7vvu6H6o368881+PfMePT3f9/AnxEl//69PfPfYvH+re49af/CM8qYmAAAFun"
  + "LAS3AQAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<505 and y<58):
        return g[y*505 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<505 and y<58):
        g[y*505 + x]=v;
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
    gw(2,8,5)
    gw(2,4,501)
    gw(2,5,48)
    gw(2,6,24048)
    gw((tm(24047,gr(2,4)))+4,td(24047,gr(2,4)),0)
    sa(24046)
    return 1
def _1():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),gr(2,4)))+4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,4)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (2)if(sp()!=0)else(20)
def _2():
    gw(2,2,1)
    sa(1)
    sa(0)
    sa(1)
    sa(1)
    return 3
def _3():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(9)
    return 4
def _4():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (19)if(sp()!=0)else(5)
def _5():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))

    sa(tm(sr(),10))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 6
def _6():
    return (3)if(sp()!=0)else(7)
def _7():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sp();
    sp();
    return 8
def _8():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (9)if(sp()!=0)else(10)
def _9():
    sa(sp()+sp());
    return 8
def _10():
    sa(sp()+sp());

    sa(sr());
    gw(2,0,sp())
    sa(0)
    sa(gr(4,0))
    sa(gr(4,0))
    return 11
def _11():
    return (12)if(sp()!=0)else(18)
def _12():
    sa(sp()-gr(2,0));


    return (17)if(sp()!=0)else(13)
def _13():
    sa(sp()*3);

    sa(sr()+2)
    sa((tm(sr(),gr(2,4)))+4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,4)))

    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+1);


    return (14)if(sr()-gr(2,8)==0)else(15)
def _14():
    global t0
    sp();
    sa(sp()+1);

    sa((tm(sr(),gr(2,4)))+4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,4)))

    v0=sp()
    t0=gr(sp(),v0)
    print(t0,end=" ",flush=True)
    sp();
    sp();
    sp();
    return 21
def _15():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+2);

    sa((tm(sr(),gr(2,4)))+4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,4)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 16
def _16():
    global t0
    sp();
    sa(sp()+1);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(sp()*t0);

    sa(sr());
    gw(2,2,sp())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),10))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 6
def _17():
    sa(sp()+1);

    sa(sr()*3)
    sa((tm(sr(),gr(2,4)))+4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,4)))

    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());
    return 11
def _18():
    sp();
    sa(sp()*3);

    sa(sr());
    sa(sr());
    sa(gr(2,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),gr(2,4)))+4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,4)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(gr(2,2))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1);

    sa((tm(sr(),gr(2,4)))+4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,4)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+2);

    sa((tm(sr(),gr(2,4)))+4)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,4)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 16
def _19():
    sa(sp()-1);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*9);
    return 4
def _20():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20]
c=0
while c<21:
    c=m[c]()
