# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="Ah+LCAAAAAAABACT7+ZgAAEWhrc3HLNvG4gwPNj/aOnLpce6Y6x9BQ++2fS7z7rFLEe77aJh8LZ5nx6rt+v5ZlxeumHSpRr5Iye+FSct+a5ivf3mqYwptbt+/vz76vX6N4/fv149e82L7/tj4v+eeOXJtiHdnWGogwObUw+EnX1we8G5TZMj2vLm3FL/aFKirliyPPQF202FtlXaq9+V3X66kC/WY6FvcOu2M8lZy9Zn9adnGq/6VPahMkDmbtyyyaUZyTOvz36+W+BWSd48p21/jyTe3Ci+rF9+3x6LWdsXZjnPiLP5/+rshA235+4p9PV6sOr8na1zfH/XbntuqPo+p058hlHFjrVsmxw3VqRVlVeaZjlbWvvNjpiSu6JcYsvh0o0X4zfXPfL6+9WF12f2pk7FZS8z5qitj8jnK6yuEZ/mVvp3iuUr1qerrz26W3NtHX+G+KsZ310FlsdKfF/7cQV/gLD+iritsx5arL3/10ru3OU7Yslz57fmCe1alfFIZcvRTQHnpk+O54pwCzv6+2H737t/pL8UmFWr/BV3lT4XtNbnv+TJ+u8FLW2r+7bf2qP13dl06609et9Xny1y9eQ+tS7fdU+D6y+RUulz1/tWtvzN/GcXaXq6faPnf75dN777yvYs/xe2s3zH14/sevJ84QmazAwAB/3uX5ICAAA="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<400 and y<518):
        return g[y*400 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<400 and y<518):
        g[y*400 + x]=v;
def rd():
    return bool(random.getrandbits(1))
def td(a,b):
    return bool(random.getrandbits(1))
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
    return (18)if(sp()!=0)else(19)
def _1():
    return (21)if(sp()!=0)else(20)
def _2():
    return (17)if(sp()!=0)else(22)
def _3():
    return (23)if(sp()!=0)else(24)
def _4():
    return (23)if(sp()!=0)else(25)
def _5():
    return (27)if(sp()!=0)else(26)
def _6():
    return (28)if(sp()!=0)else(29)
def _7():
    return (30)if(sp()!=0)else(32)
def _8():
    return (38)if(sp()!=0)else(34)
def _9():
    return (41)if(sp()!=0)else(40)
def _10():
    return (39)if(sp()!=0)else(42)
def _11():
    return (46)if(sp()!=0)else(43)
def _12():
    return (44)if(sp()!=0)else(36)
def _13():
    return (35)if(sp()!=0)else(45)
def _14():
    return (33)if(sp()!=0)else(36)
def _15():
    return (35)if(sp()!=0)else(37)
def _16():
    gw(1,0,400)
    gw(2,0,500)
    gw(0,0,200000)
    gw(3,0,2)
    gw(0,3,32)
    gw(1,3,32)
    return 17
def _17():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88)
    sa((gr(3,0))+(gr(3,0)))
    sa((1)if((gr(0,0))>((gr(3,0))+(gr(3,0))))else(0))
    return 0
def _18():
    sa(sr())
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(gr(3,0))
    sa(sp()+sp());
    sa(sr())
    sa(gr(0,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 0
def _19():
    sp()
    return 20
def _20():
    sa((gr(3,0))+(1))
    gw(3,0,(gr(3,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    return 1
def _21():
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return 2
def _22():
    gw(4,0,0)
    gw(3,0,0)
    return 23
def _23():
    sa((gr(3,0))+(1))
    gw(3,0,(gr(3,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(88)
    v0=sp()
    sa(sp()-v0)
    return 3
def _24():
    sa(gr(3,0))
    sa(gr(4,0))
    gw(4,0,(gr(4,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return 4
def _25():
    gw(tm((gr(4,0))-(1),gr(1,0)),(td((gr(4,0))-(1),gr(1,0)))+(3),0)
    gw(4,0,0)
    gw(5,0,0)
    sa(1)
    sa(1)
    sa(tm(1,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3))))
    return 5
def _26():
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)))
    gw(5,0,(gr(5,0))+(1))
    v0=sp()
    sa(td(sp(),v0))
    return 27
def _27():
    sa(sr())
    sa((gr(4,0))+(1))
    gw(4,0,(gr(4,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return 6
def _28():
    sa(sr())
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)))
    v0=sp()
    sa(tm(sp(),v0))
    return 5
def _29():
    sp()
    sa((gr(5,0))-(4))
    return 7
def _30():
    gw(4,0,0)
    gw(5,0,0)
    return 31
def _31():
    sa(4)
    sa(sp()+sp());
    sa(sr())
    sa(sr())
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)))
    v0=sp()
    sa(tm(sp(),v0))
    return 5
def _32():
    gw(8,0,0)
    sa(sr())
    sa(sr())
    sa(sr())
    sa(4)
    sa(sp()+sp());
    gw(6,0,sp())
    gw(7,0,sp())
    sa(3)
    v0=sp()
    sa(sp()-v0)
    return 33
def _33():
    sa(sr())
    sa(gr(7,0))
    v0=sp()
    sa(sp()-v0)
    return 8
def _34():
    sa((gr(8,0))+(1))
    gw(8,0,(gr(8,0))+(1))
    sa(4)
    v0=sp()
    sa(sp()-v0)
    return 15
def _35():
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(gr(6,0))
    v0=sp()
    sa(sp()-v0)
    return 14
def _36():
    gw(4,0,0)
    gw(5,0,0)
    sp()
    return 31
def _37():
    sa(3)
    v0=sp()
    sa(sp()-v0)
    print(sp(),end="",flush=True)
    sp()
    return 47
def _38():
    gw(4,0,0)
    gw(5,0,0)
    sa(sr())
    return 39
def _39():
    sa(sr())
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)))
    v0=sp()
    sa(tm(sp(),v0))
    return 9
def _40():
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)))
    gw(5,0,(gr(5,0))+(1))
    v0=sp()
    sa(td(sp(),v0))
    return 41
def _41():
    sa(sr())
    sa((gr(4,0))+(1))
    gw(4,0,(gr(4,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return 10
def _42():
    sp()
    sa((gr(5,0))-(4))
    return 11
def _43():
    gw(8,0,(gr(8,0))+(1))
    return 44
def _44():
    sa((gr(8,0))-(4))
    return 13
def _45():
    sa(3)
    v0=sp()
    sa(sp()-v0)
    print(sp(),end="",flush=True)
    sp()
    return 47
def _46():
    gw(8,0,0)
    sa(sr())
    sa(gr(7,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 12
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46]
c=16
while c<47:
    c=m[c]()