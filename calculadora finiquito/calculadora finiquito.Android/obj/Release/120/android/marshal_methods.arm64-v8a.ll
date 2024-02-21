; ModuleID = 'obj\Release\120\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Release\120\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [96 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 5
	i64 232391251801502327, ; 1: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 29
	i64 665971171124838059, ; 2: calculadora finiquito => 0x93e01406d8bfeab => 2
	i64 702024105029695270, ; 3: System.Drawing.Common => 0x9be17343c0e7726 => 46
	i64 720058930071658100, ; 4: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 23
	i64 872800313462103108, ; 5: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 21
	i64 996343623809489702, ; 6: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 36
	i64 1000557547492888992, ; 7: Mono.Security.dll => 0xde2b1c9cba651a0 => 47
	i64 1120440138749646132, ; 8: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 38
	i64 1425944114962822056, ; 9: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 1
	i64 1523653601895066694, ; 10: calculadora finiquito.dll => 0x15251ae0d5b32c46 => 2
	i64 1624659445732251991, ; 11: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 14
	i64 1654459637124685550, ; 12: calculadora finiquito.Android.dll => 0x16f5d2463609deee => 0
	i64 1795316252682057001, ; 13: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 15
	i64 1836611346387731153, ; 14: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 29
	i64 1981742497975770890, ; 15: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 26
	i64 2262844636196693701, ; 16: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 21
	i64 2329709569556905518, ; 17: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 25
	i64 2470498323731680442, ; 18: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 17
	i64 2547086958574651984, ; 19: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 13
	i64 2592350477072141967, ; 20: System.Xml.dll => 0x23f9e10627330e8f => 12
	i64 2624866290265602282, ; 21: mscorlib.dll => 0x246d65fbde2db8ea => 6
	i64 2960931600190307745, ; 22: Xamarin.Forms.Core => 0x2917579a49927da1 => 33
	i64 3017704767998173186, ; 23: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 38
	i64 3289520064315143713, ; 24: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 24
	i64 3522470458906976663, ; 25: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 30
	i64 3531994851595924923, ; 26: System.Numerics => 0x31042a9aade235bb => 11
	i64 3596565917252612164, ; 27: Xamarin.Forms.OpenWhatsApp => 0x31e991a5751e7044 => 34
	i64 3727469159507183293, ; 28: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 28
	i64 4525561845656915374, ; 29: System.ServiceModel.Internals => 0x3ece06856b710dae => 45
	i64 4794310189461587505, ; 30: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 13
	i64 4795410492532947900, ; 31: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 30
	i64 4858694693494254557, ; 32: calculadora finiquito.Android => 0x436d8d14cdccebdd => 0
	i64 5142919913060024034, ; 33: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 35
	i64 5203618020066742981, ; 34: Xamarin.Essentials => 0x4836f704f0e652c5 => 32
	i64 5507995362134886206, ; 35: System.Core.dll => 0x4c705499688c873e => 8
	i64 6085203216496545422, ; 36: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 36
	i64 6086316965293125504, ; 37: FormsViewGroup.dll => 0x5476f10882baef80 => 3
	i64 6292085478809632784, ; 38: Plugin.MtAdmob => 0x5751fa67f4d78010 => 7
	i64 6401687960814735282, ; 39: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 25
	i64 6548213210057960872, ; 40: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 20
	i64 6659513131007730089, ; 41: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 23
	i64 7635363394907363464, ; 42: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 33
	i64 7637365915383206639, ; 43: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 32
	i64 7654504624184590948, ; 44: System.Net.Http => 0x6a3a4366801b8264 => 10
	i64 7731117178672402408, ; 45: Xamarin.GooglePlayServices.Ads.Lite.dll => 0x6b4a721cdfb04fe8 => 41
	i64 7735352534559001595, ; 46: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 44
	i64 7836164640616011524, ; 47: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 14
	i64 8083354569033831015, ; 48: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 24
	i64 8167236081217502503, ; 49: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 4
	i64 8626175481042262068, ; 50: Java.Interop => 0x77b654e585b55834 => 4
	i64 8853378295825400934, ; 51: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 43
	i64 9324707631942237306, ; 52: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 15
	i64 9627569974474420064, ; 53: Plugin.MtAdmob.dll => 0x859bffe1fac3af60 => 7
	i64 9662334977499516867, ; 54: System.Numerics.dll => 0x8617827802b0cfc3 => 11
	i64 9678050649315576968, ; 55: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 17
	i64 9808709177481450983, ; 56: Mono.Android.dll => 0x881f890734e555e7 => 5
	i64 9998632235833408227, ; 57: Mono.Security => 0x8ac2470b209ebae3 => 47
	i64 10038780035334861115, ; 58: System.Net.Http.dll => 0x8b50e941206af13b => 10
	i64 10078351459017364956, ; 59: Xamarin.GooglePlayServices.Ads.Lite => 0x8bdd7f412c4515dc => 41
	i64 10229024438826829339, ; 60: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 20
	i64 10321854143672141184, ; 61: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 42
	i64 10430153318873392755, ; 62: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 18
	i64 10549908655231907690, ; 63: Xamarin.Forms.OpenWhatsApp.dll => 0x9268ce06afeab76a => 34
	i64 11006094147825606368, ; 64: Xamarin.Google.UserMessagingPlatform => 0x98bd80508da69ee0 => 40
	i64 11023048688141570732, ; 65: System.Core => 0x98f9bc61168392ac => 8
	i64 11037814507248023548, ; 66: System.Xml => 0x992e31d0412bf7fc => 12
	i64 11162124722117608902, ; 67: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 31
	i64 11340910727871153756, ; 68: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 19
	i64 11529969570048099689, ; 69: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 31
	i64 12451044538927396471, ; 70: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 22
	i64 12466513435562512481, ; 71: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 27
	i64 12538491095302438457, ; 72: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 16
	i64 12963446364377008305, ; 73: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 46
	i64 13370592475155966277, ; 74: System.Runtime.Serialization => 0xb98de304062ea945 => 1
	i64 13454009404024712428, ; 75: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 39
	i64 13465488254036897740, ; 76: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 44
	i64 13572454107664307259, ; 77: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 28
	i64 13828521679616088467, ; 78: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 43
	i64 13959074834287824816, ; 79: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 22
	i64 13967638549803255703, ; 80: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 35
	i64 14124974489674258913, ; 81: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 16
	i64 14792063746108907174, ; 82: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 39
	i64 14852515768018889994, ; 83: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 19
	i64 15370334346939861994, ; 84: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 18
	i64 15609085926864131306, ; 85: System.dll => 0xd89e9cf3334914ea => 9
	i64 15810740023422282496, ; 86: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 37
	i64 16154507427712707110, ; 87: System => 0xe03056ea4e39aa26 => 9
	i64 16833383113903931215, ; 88: mscorlib => 0xe99c30c1484d7f4f => 6
	i64 17087111168882403219, ; 89: Xamarin.Google.UserMessagingPlatform.dll => 0xed219d13a2d86793 => 40
	i64 17704177640604968747, ; 90: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 27
	i64 17710060891934109755, ; 91: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 26
	i64 17882897186074144999, ; 92: FormsViewGroup => 0xf82cd03e3ac830e7 => 3
	i64 17891337867145587222, ; 93: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 42
	i64 17892495832318972303, ; 94: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 37
	i64 18129453464017766560 ; 95: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 45
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [96 x i32] [
	i32 5, i32 29, i32 2, i32 46, i32 23, i32 21, i32 36, i32 47, ; 0..7
	i32 38, i32 1, i32 2, i32 14, i32 0, i32 15, i32 29, i32 26, ; 8..15
	i32 21, i32 25, i32 17, i32 13, i32 12, i32 6, i32 33, i32 38, ; 16..23
	i32 24, i32 30, i32 11, i32 34, i32 28, i32 45, i32 13, i32 30, ; 24..31
	i32 0, i32 35, i32 32, i32 8, i32 36, i32 3, i32 7, i32 25, ; 32..39
	i32 20, i32 23, i32 33, i32 32, i32 10, i32 41, i32 44, i32 14, ; 40..47
	i32 24, i32 4, i32 4, i32 43, i32 15, i32 7, i32 11, i32 17, ; 48..55
	i32 5, i32 47, i32 10, i32 41, i32 20, i32 42, i32 18, i32 34, ; 56..63
	i32 40, i32 8, i32 12, i32 31, i32 19, i32 31, i32 22, i32 27, ; 64..71
	i32 16, i32 46, i32 1, i32 39, i32 44, i32 28, i32 43, i32 22, ; 72..79
	i32 35, i32 16, i32 39, i32 19, i32 18, i32 9, i32 37, i32 9, ; 80..87
	i32 6, i32 40, i32 27, i32 26, i32 3, i32 42, i32 37, i32 45 ; 96..95
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
