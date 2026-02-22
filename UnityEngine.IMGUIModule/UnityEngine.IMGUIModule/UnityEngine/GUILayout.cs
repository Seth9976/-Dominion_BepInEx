using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class GUILayout : Object
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x00009EBC File Offset: 0x000080BC
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayout()
		{
			Il2CppClassPointerStore<GUILayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayout>.NativeClassPtr);
			GUILayout.NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663437);
			GUILayout.NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663438);
			GUILayout.NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663439);
			GUILayout.NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663440);
			GUILayout.NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663441);
			GUILayout.NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663442);
			GUILayout.NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663443);
			GUILayout.NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663444);
			GUILayout.NativeMethodInfoPtr_BeginVertical_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663445);
			GUILayout.NativeMethodInfoPtr_BeginVertical_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663446);
			GUILayout.NativeMethodInfoPtr_EndVertical_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663447);
			GUILayout.NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663448);
			GUILayout.NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663449);
			GUILayout.NativeMethodInfoPtr_EndArea_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663450);
			GUILayout.NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663451);
			GUILayout.NativeMethodInfoPtr_EndScrollView_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663452);
			GUILayout.NativeMethodInfoPtr_EndScrollView_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663453);
			GUILayout.NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663454);
			GUILayout.NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663455);
			GUILayout.NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663456);
			GUILayout.NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663457);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000A090 File Offset: 0x00008290
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85758, RefRangeEnd = 85761, XrefRangeStart = 85730, XrefRangeEnd = 85758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Label(string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000A0E8 File Offset: 0x000082E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85761, XrefRangeEnd = 85777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoLabel(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000A144 File Offset: 0x00008344
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 85801, RefRangeEnd = 85805, XrefRangeStart = 85777, XrefRangeEnd = 85801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Button(string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000A1A4 File Offset: 0x000083A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85805, XrefRangeEnd = 85817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000A20C File Offset: 0x0000840C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 85882, RefRangeEnd = 85890, XrefRangeStart = 85817, XrefRangeEnd = 85882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlexibleSpace()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000A234 File Offset: 0x00008434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85920, RefRangeEnd = 85923, XrefRangeStart = 85890, XrefRangeEnd = 85920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginHorizontal([Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000A278 File Offset: 0x00008478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85923, XrefRangeEnd = 85945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginHorizontal(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000A2E0 File Offset: 0x000084E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85949, RefRangeEnd = 85952, XrefRangeStart = 85945, XrefRangeEnd = 85949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndHorizontal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000A308 File Offset: 0x00008508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85982, RefRangeEnd = 85983, XrefRangeStart = 85952, XrefRangeEnd = 85982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginVertical([Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginVertical_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000A34C File Offset: 0x0000854C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85983, XrefRangeEnd = 86005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginVertical(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginVertical_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000A3B4 File Offset: 0x000085B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86009, RefRangeEnd = 86010, XrefRangeStart = 86005, XrefRangeEnd = 86009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndVertical()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndVertical_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000A3DC File Offset: 0x000085DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86019, RefRangeEnd = 86020, XrefRangeStart = 86010, XrefRangeEnd = 86019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginArea(Rect screenRect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000A410 File Offset: 0x00008610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86050, RefRangeEnd = 86051, XrefRangeStart = 86020, XrefRangeEnd = 86050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000A468 File Offset: 0x00008668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86069, RefRangeEnd = 86070, XrefRangeStart = 86051, XrefRangeEnd = 86069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndArea()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndArea_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000A490 File Offset: 0x00008690
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86093, RefRangeEnd = 86095, XrefRangeStart = 86070, XrefRangeEnd = 86093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysShowHorizontal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysShowVertical;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(horizontalScrollbar);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(verticalScrollbar);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(background);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000A544 File Offset: 0x00008744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86103, RefRangeEnd = 86105, XrefRangeStart = 86095, XrefRangeEnd = 86103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndScrollView()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndScrollView_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000A56C File Offset: 0x0000876C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86105, XrefRangeEnd = 86113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndScrollView(bool handleScrollWheel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleScrollWheel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_EndScrollView_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000A5A0 File Offset: 0x000087A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86113, XrefRangeEnd = 86120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption Width(float width)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000A5E0 File Offset: 0x000087E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86120, XrefRangeEnd = 86127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption Height(float height)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000A620 File Offset: 0x00008820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86127, XrefRangeEnd = 86134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption ExpandWidth(bool expand)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000A660 File Offset: 0x00008860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86134, XrefRangeEnd = 86141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption ExpandHeight(bool expand)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000280E File Offset: 0x00000A0E
		public static void Label(string text, params GUILayoutOption[] options)
		{
			GUILayout.Label(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000281C File Offset: 0x00000A1C
		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return GUILayout.Button(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000282A File Offset: 0x00000A2A
		public static void BeginHorizontal(params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002837 File Offset: 0x00000A37
		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002846 File Offset: 0x00000A46
		public static void BeginVertical(params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002853 File Offset: 0x00000A53
		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002862 File Offset: 0x00000A62
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002878 File Offset: 0x00000A78
		public GUILayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002881 File Offset: 0x00000A81
		public static void Label(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), GUI.skin.label, options);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000289B File Offset: 0x00000A9B
		public static void Label(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.Label(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000028A9 File Offset: 0x00000AA9
		public static void Label(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(content, GUI.skin.label, options);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000028BE File Offset: 0x00000ABE
		public static void Label(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.Label(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000028CC File Offset: 0x00000ACC
		public static void Label(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000028DD File Offset: 0x00000ADD
		public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000028EC File Offset: 0x00000AEC
		public static void Label(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000028FD File Offset: 0x00000AFD
		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000290C File Offset: 0x00000B0C
		public static void Label(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(content, style, options);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002918 File Offset: 0x00000B18
		public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002927 File Offset: 0x00000B27
		public static void Box(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), GUI.skin.box, options);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002941 File Offset: 0x00000B41
		public static void Box(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.Box(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000294F File Offset: 0x00000B4F
		public static void Box(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), GUI.skin.box, options);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002969 File Offset: 0x00000B69
		public static void Box(string text, params GUILayoutOption[] options)
		{
			GUILayout.Box(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002977 File Offset: 0x00000B77
		public static void Box(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(content, GUI.skin.box, options);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000298C File Offset: 0x00000B8C
		public static void Box(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.Box(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000299A File Offset: 0x00000B9A
		public static void Box(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000029AB File Offset: 0x00000BAB
		public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000029BA File Offset: 0x00000BBA
		public static void Box(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000029CB File Offset: 0x00000BCB
		public static void Box(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000029DA File Offset: 0x00000BDA
		public static void Box(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(content, style, options);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000029E6 File Offset: 0x00000BE6
		public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000029F5 File Offset: 0x00000BF5
		public static void DoBox(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUI.Box(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A6A0 File Offset: 0x000088A0
		public static bool Button(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002A08 File Offset: 0x00000C08
		public static bool Button(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Button(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A6C8 File Offset: 0x000088C8
		public static bool Button(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(content, GUI.skin.button, options);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002A16 File Offset: 0x00000C16
		public static bool Button(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Button(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A6EC File Offset: 0x000088EC
		public static bool Button(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002A24 File Offset: 0x00000C24
		public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000A70C File Offset: 0x0000890C
		public static bool Button(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002A33 File Offset: 0x00000C33
		public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A72C File Offset: 0x0000892C
		public static bool Button(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(content, style, options);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002A42 File Offset: 0x00000C42
		public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A748 File Offset: 0x00008948
		public static bool RepeatButton(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002A51 File Offset: 0x00000C51
		public static bool RepeatButton(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A770 File Offset: 0x00008970
		public static bool RepeatButton(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), GUI.skin.button, options);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002A5F File Offset: 0x00000C5F
		public static bool RepeatButton(string text, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A798 File Offset: 0x00008998
		public static bool RepeatButton(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(content, GUI.skin.button, options);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002A6D File Offset: 0x00000C6D
		public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A7BC File Offset: 0x000089BC
		public static bool RepeatButton(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002A7B File Offset: 0x00000C7B
		public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A7DC File Offset: 0x000089DC
		public static bool RepeatButton(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002A8A File Offset: 0x00000C8A
		public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A7FC File Offset: 0x000089FC
		public static bool RepeatButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(content, style, options);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002A99 File Offset: 0x00000C99
		public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A818 File Offset: 0x00008A18
		public static bool DoRepeatButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.RepeatButton(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A83C File Offset: 0x00008A3C
		public static string TextField(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, false, GUI.skin.textField, options);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002AA8 File Offset: 0x00000CA8
		public static string TextField(string text, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000A864 File Offset: 0x00008A64
		public static string TextField(string text, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, false, GUI.skin.textField, options);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002AB6 File Offset: 0x00000CB6
		public static string TextField(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000A88C File Offset: 0x00008A8C
		public static string TextField(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, false, style, options);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		public static string TextField(string text, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, false, style, options);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000A8C4 File Offset: 0x00008AC4
		public static string PasswordField(string password, char maskChar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, GUI.skin.textField, options);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002AE4 File Offset: 0x00000CE4
		public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000A8EC File Offset: 0x00008AEC
		public static string PasswordField(string password, char maskChar, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, GUI.skin.textField, options);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002AF3 File Offset: 0x00000CF3
		public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000A914 File Offset: 0x00008B14
		public static string PasswordField(string password, char maskChar, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, style, options);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002B03 File Offset: 0x00000D03
		public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000A930 File Offset: 0x00008B30
		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUIContent guicontent = GUIContent.Temp(GUI.PasswordFieldGetStrToShow(password, maskChar));
			return GUI.PasswordField(GUILayoutUtility.GetRect(guicontent, GUI.skin.textField, options), password, maskChar, maxLength, style);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002B13 File Offset: 0x00000D13
		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000A96C File Offset: 0x00008B6C
		public static string TextArea(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, true, GUI.skin.textArea, options);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002B25 File Offset: 0x00000D25
		public static string TextArea(string text, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000A994 File Offset: 0x00008B94
		public static string TextArea(string text, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, true, GUI.skin.textArea, options);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002B33 File Offset: 0x00000D33
		public static string TextArea(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000A9BC File Offset: 0x00008BBC
		public static string TextArea(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, true, style, options);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002B42 File Offset: 0x00000D42
		public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		public static string TextArea(string text, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, true, style, options);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002B51 File Offset: 0x00000D51
		public static string TextArea(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		public static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			GUIContent guicontent = GUIContent.Temp(text);
			bool flag = GUIUtility.keyboardControl != controlID;
			if (flag)
			{
				guicontent = GUIContent.Temp(text);
			}
			else
			{
				guicontent = GUIContent.Temp(String.Concat(text, GUIUtility.compositionString));
			}
			Rect rect = GUILayoutUtility.GetRect(guicontent, style, options);
			bool flag2 = GUIUtility.keyboardControl == controlID;
			if (flag2)
			{
				guicontent = GUIContent.Temp(text);
			}
			GUI.DoTextField(rect, controlID, guicontent, multiline, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000AA70 File Offset: 0x00008C70
		public static bool Toggle(bool value, Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), GUI.skin.toggle, options);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002B61 File Offset: 0x00000D61
		public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000AA9C File Offset: 0x00008C9C
		public static bool Toggle(bool value, string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(text), GUI.skin.toggle, options);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002B70 File Offset: 0x00000D70
		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		public static bool Toggle(bool value, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, content, GUI.skin.toggle, options);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002B7F File Offset: 0x00000D7F
		public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000AAEC File Offset: 0x00008CEC
		public static bool Toggle(bool value, Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002B8E File Offset: 0x00000D8E
		public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000AB0C File Offset: 0x00008D0C
		public static bool Toggle(bool value, string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(text), style, options);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002B9E File Offset: 0x00000D9E
		public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000AB2C File Offset: 0x00008D2C
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, content, style, options);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002BAE File Offset: 0x00000DAE
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000AB48 File Offset: 0x00008D48
		public static bool DoToggle(bool value, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.Toggle(GUILayoutUtility.GetRect(content, style, options), value, content, style);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000AB6C File Offset: 0x00008D6C
		public static int Toolbar(int selected, Il2CppStringArray texts, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), GUI.skin.button, options);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002BBE File Offset: 0x00000DBE
		public static int Toolbar(int selected, Il2CppStringArray texts, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000AB98 File Offset: 0x00008D98
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), GUI.skin.button, options);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002BCD File Offset: 0x00000DCD
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000ABC4 File Offset: 0x00008DC4
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, GUI.skin.button, options);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002BDC File Offset: 0x00000DDC
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), style, options);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002BEB File Offset: 0x00000DEB
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000AC08 File Offset: 0x00008E08
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), style, options);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002BFB File Offset: 0x00000DFB
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000AC28 File Offset: 0x00008E28
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), style, buttonSize, options);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002C0B File Offset: 0x00000E0B
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000AC4C File Offset: 0x00008E4C
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), style, buttonSize, options);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002C1D File Offset: 0x00000E1D
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000AC70 File Offset: 0x00008E70
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, style, GUI.ToolbarButtonSize.Fixed, options);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002C2F File Offset: 0x00000E2F
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000AC8C File Offset: 0x00008E8C
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, null, style, buttonSize, options);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002C3F File Offset: 0x00000E3F
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000ACAC File Offset: 0x00008EAC
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, GUI.ToolbarButtonSize.Fixed, options);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002C51 File Offset: 0x00000E51
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002C63 File Offset: 0x00000E63
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002C70 File Offset: 0x00000E70
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000ACCC File Offset: 0x00008ECC
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, GUI.skin.button, options);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002C84 File Offset: 0x00000E84
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, texts, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, GUI.skin.button, options);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002C94 File Offset: 0x00000E94
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, images, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000AD24 File Offset: 0x00008F24
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> content, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, GUI.skin.button, options);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> content, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000AD4C File Offset: 0x00008F4C
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, style, options);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, texts, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000AD70 File Offset: 0x00008F70
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, style, options);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002CC6 File Offset: 0x00000EC6
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, images, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000AD94 File Offset: 0x00008F94
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.SelectionGrid(GUIGridSizer.GetRect(contents, xCount, style, options), selected, contents, xCount, style);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, contents, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000ADBC File Offset: 0x00008FBC
		public static float HorizontalSlider(float value, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, options);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002CEA File Offset: 0x00000EEA
		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalSlider(value, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002CFA File Offset: 0x00000EFA
		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000AE0C File Offset: 0x0000900C
		public static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.HorizontalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000AE3C File Offset: 0x0000903C
		public static float VerticalSlider(float value, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, options);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002D0E File Offset: 0x00000F0E
		public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalSlider(value, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000AE6C File Offset: 0x0000906C
		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002D1E File Offset: 0x00000F1E
		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000AE8C File Offset: 0x0000908C
		public static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.VerticalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n\n"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002D32 File Offset: 0x00000F32
		public static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000AEBC File Offset: 0x000090BC
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, options);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002D46 File Offset: 0x00000F46
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000AEE4 File Offset: 0x000090E4
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.HorizontalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), style, options), value, size, leftValue, rightValue, style);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002D58 File Offset: 0x00000F58
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000AF14 File Offset: 0x00009114
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, options);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002D6C File Offset: 0x00000F6C
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000AF3C File Offset: 0x0000913C
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.VerticalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n"), style, options), value, size, topValue, bottomValue, style);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002D7E File Offset: 0x00000F7E
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002D92 File Offset: 0x00000F92
		public static void Space(float pixels)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002D9F File Offset: 0x00000F9F
		public static void BeginHorizontal(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.none, style, options);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002DAF File Offset: 0x00000FAF
		public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002DBD File Offset: 0x00000FBD
		public static void BeginHorizontal(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(text), style, options);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002DCE File Offset: 0x00000FCE
		public static void BeginHorizontal(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002DDD File Offset: 0x00000FDD
		public static void BeginHorizontal(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002DEE File Offset: 0x00000FEE
		public static void BeginHorizontal(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002DFD File Offset: 0x00000FFD
		public static void BeginVertical(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.none, style, options);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002E0D File Offset: 0x0000100D
		public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002E1B File Offset: 0x0000101B
		public static void BeginVertical(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(text), style, options);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002E2C File Offset: 0x0000102C
		public static void BeginVertical(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002E3B File Offset: 0x0000103B
		public static void BeginVertical(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(image), style, options);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002E4C File Offset: 0x0000104C
		public static void BeginVertical(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002E5B File Offset: 0x0000105B
		public static void BeginArea(Rect screenRect, string text)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), GUIStyle.none);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002E70 File Offset: 0x00001070
		public static void BeginArea(Rect screenRect, Texture image)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), GUIStyle.none);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002E85 File Offset: 0x00001085
		public static void BeginArea(Rect screenRect, GUIContent content)
		{
			GUILayout.BeginArea(screenRect, content, GUIStyle.none);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002E95 File Offset: 0x00001095
		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, style);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002EA5 File Offset: 0x000010A5
		public static void BeginArea(Rect screenRect, string text, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), style);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002EB6 File Offset: 0x000010B6
		public static void BeginArea(Rect screenRect, Texture image, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), style);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000AF6C File Offset: 0x0000916C
		public static Vector2 BeginScrollView(Vector2 scrollPosition, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002EC7 File Offset: 0x000010C7
		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002ED5 File Offset: 0x000010D5
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000AFE4 File Offset: 0x000091E4
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002EE5 File Offset: 0x000010E5
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000B00C File Offset: 0x0000920C
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style)
		{
			Il2CppReferenceArray<GUILayoutOption> il2CppReferenceArray = null;
			return GUILayout.BeginScrollView(scrollPosition, style, il2CppReferenceArray);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000B028 File Offset: 0x00009228
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			string name = style.name;
			GUIStyle guistyle = GUI.skin.FindStyle(String.Concat(name, "VerticalScrollbar"));
			bool flag = guistyle == null;
			if (flag)
			{
				guistyle = GUI.skin.verticalScrollbar;
			}
			GUIStyle guistyle2 = GUI.skin.FindStyle(String.Concat(name, "HorizontalScrollbar"));
			bool flag2 = guistyle2 == null;
			if (flag2)
			{
				guistyle2 = GUI.skin.horizontalScrollbar;
			}
			return GUILayout.BeginScrollView(scrollPosition, false, false, guistyle2, guistyle, style, options);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002EF5 File Offset: 0x000010F5
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000B0A4 File Offset: 0x000092A4
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002F04 File Offset: 0x00001104
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000B0D0 File Offset: 0x000092D0
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), GUI.skin.window, options);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002F18 File Offset: 0x00001118
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000B0FC File Offset: 0x000092FC
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), GUI.skin.window, options);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002F2A File Offset: 0x0000112A
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000B128 File Offset: 0x00009328
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, GUI.skin.window, options);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002F3C File Offset: 0x0000113C
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000B150 File Offset: 0x00009350
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), style, options);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002F4E File Offset: 0x0000114E
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000B174 File Offset: 0x00009374
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), style, options);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002F62 File Offset: 0x00001162
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000B198 File Offset: 0x00009398
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, style, options);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002F76 File Offset: 0x00001176
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000B1B8 File Offset: 0x000093B8
		public static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUIUtility.CheckOnGUI();
			GUILayout.LayoutedWindow layoutedWindow = new GUILayout.LayoutedWindow(func, screenRect, content, options, style);
			return GUI.Window(id, screenRect, new GUI.WindowFunction(layoutedWindow.DoWindow), content, style);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000B1F4 File Offset: 0x000093F4
		public static GUILayoutOption MinWidth(float minWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minWidth, minWidth);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000B214 File Offset: 0x00009414
		public static GUILayoutOption MaxWidth(float maxWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxWidth, maxWidth);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000B234 File Offset: 0x00009434
		public static GUILayoutOption MinHeight(float minHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minHeight, minHeight);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000B254 File Offset: 0x00009454
		public static GUILayoutOption MaxHeight(float maxHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxHeight, maxHeight);
		}

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_BeginVertical_Public_Static_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_BeginVertical_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_EndVertical_Public_Static_Void_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_EndArea_Public_Static_Void_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_BeginScrollView_Public_Static_Vector2_Vector2_Boolean_Boolean_GUIStyle_GUIStyle_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_EndScrollView_Public_Static_Void_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_EndScrollView_Internal_Static_Void_Boolean_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0;

		// Token: 0x02000062 RID: 98
		public sealed class LayoutedWindow
		{
		}

		// Token: 0x02000063 RID: 99
		public class HorizontalScope : GUI.Scope
		{
		}

		// Token: 0x02000064 RID: 100
		public class VerticalScope : GUI.Scope
		{
		}

		// Token: 0x02000065 RID: 101
		public class AreaScope : GUI.Scope
		{
		}

		// Token: 0x02000066 RID: 102
		public class ScrollViewScope : GUI.Scope
		{
		}
	}
}
