#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhrc3HLNvG4gwPNj/aOnLpce6Y6x9BQ++2fS7z7rFLEe77aJh8LZ5nx6rt+v5ZlxeumHSpRr5Iye+FSct+a5ivf3mqYwptbt+/vz76vX6"
  + "N4/fv149e82L7/tj4v+eeOXJtiHdnWGogwObUw+EnX1we8G5TZMj2vLm3FL/aFKirliyPPQF202FtlXaq9+V3X66kC/WY6FvcOu2M8lZy9Zn9adnGq/6VPahMkDmbtyy"
  + "yaUZyTOvz36+W+BWSd48p21/jyTe3Ci+rF9+3x6LWdsXZjnPiLP5/+rshA235+4p9PV6sOr8na1zfH/XbntuqPo+p058hlHFjrVsmxw3VqRVlVeaZjlbWvvNjpiSu6Jc"
  + "Ysvh0o0X4zfXPfL6+9WF12f2pk7FZS8z5qitj8jnK6yuEZ/mVvp3iuUr1qerrz26W3NtHX+G+KsZ310FlsdKfF/7cQV/gLD+iritsx5arL3/10ru3OU7Yslz57fmCe1a"
  + "lfFIZcvRTQHnpk+O54pwCzv6+2H737t/pL8UmFWr/BV3lT4XtNbnv+TJ+u8FLW2r+7bf2qP13dl06609et9Xny1y9eQ+tS7fdU+D6y+RUulz1/tWtvzN/GcXaXq6faPn"
  + "f75dN777yvYs/xe2s3zH14/sevJ84QmazAwAB/3uX5ICAAA=")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<400 and y<518):
        return g[y*400 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<400 and y<518):
        g[y*400 + x]=v;
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
    gw(1,0,400)
    gw(2,0,500)
    gw(0,0,200000)
    gw(3,0,2)
    gw(0,3,32)
    gw(1,3,32)
    return 1
def _1():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(0,0))else(0))
    return 2
def _2():
    return (32)if(sp()!=0)else(3)
def _3():
    sp();
    return 4
def _4():
    global t0
    sa(gr(3,0)+1)
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    return 5
def _5():
    global t0
    return (6)if((t0)!=0)else(4)
def _6():
    return (1)if(gr(0,0)>gr(3,0))else(7)
def _7():
    gw(4,0,0)
    gw(3,0,0)
    return 8
def _8():
    global t0
    sa(gr(3,0)+1)
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-88
    return 9
def _9():
    global t0
    return (8)if((t0)!=0)else(10)
def _10():
    sa(gr(3,0))
    sa(gr(4,0))
    sa(gr(4,0))
    gw(4,0,gr(4,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())

    return (8)if(gr(0,0)>gr(3,0))else(11)
def _11():
    gw(tm(gr(4,0)-1,gr(1,0)),(td(gr(4,0)-1,gr(1,0)))+3,0)
    gw(4,0,0)
    gw(5,0,0)
    sa(1)
    sa(1)
    sa(tm(1,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)))
    return 12
def _12():
    return (13)if(sp()!=0)else(31)
def _13():
    global t0
    global t1
    sa(sr());
    sa(gr(4,0)+1)
    sa(gr(4,0)+1)
    gw(4,0,gr(4,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    sa((1)if(sp()<t0)else(0))

    t1=sp()

    return (14)if((t1)!=0)else(30)
def _14():
    sp();

    return (20)if(gr(5,0)!=4)else(15)
def _15():
    gw(8,0,0)
    sa(sr());
    sa(sr());
    gw(6,0,sr()+4)
    gw(7,0,sp())
    sa(sp()-3)
    return 16
def _16():
    return (22)if((sr()-gr(7,0))!=0)else(17)
def _17():
    global t0
    t0=gr(8,0)-3
    gw(8,0,gr(8,0)+1)

    return (18)if((t0)!=0)else(21)
def _18():
    sa(sp()+1)


    return (16)if((sr()-gr(6,0))!=0)else(19)
def _19():
    sp();
    return 20
def _20():
    gw(4,0,0)
    gw(5,0,0)
    sa(sp()+4)

    sa(sr());
    sa(tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)))
    return 12
def _21():
    sa(sp()-3)

    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()

    sp();
    return 33
def _22():
    gw(4,0,0)
    gw(5,0,0)
    sa(sr());
    return 23
def _23():
    return (24)if((tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)))!=0)else(29)
def _24():
    global t0
    global t1
    sa(sr());
    sa(gr(4,0)+1)
    sa(gr(4,0)+1)
    gw(4,0,gr(4,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    sa((1)if(sp()<t0)else(0))

    t1=sp()

    return (25)if((t1)!=0)else(23)
def _25():
    sp();

    return (26)if(gr(5,0)!=4)else(28)
def _26():
    gw(8,0,0)

    return (27)if(sr()<gr(7,0))else(19)
def _27():
    return (18)if(gr(8,0)!=4)else(21)
def _28():
    gw(8,0,gr(8,0)+1)
    return 27
def _29():
    sa(td(sp(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)))

    gw(5,0,gr(5,0)+1)
    return 24
def _30():
    sa(tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)))
    return 12
def _31():
    sa(td(sp(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)))

    gw(5,0,gr(5,0)+1)
    return 13
def _32():
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

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(3,0))

    sa((1)if(sr()<gr(0,0))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32]
c=0
while c<33:
    c=m[c]()
