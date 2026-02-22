using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public sealed class GUIClip : Object
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00009070 File Offset: 0x00007270
		// Note: this type is marked as 'beforefieldinit'.
		static GUIClip()
		{
			Il2CppClassPointerStore<GUIClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIClip>.NativeClassPtr);
			GUIClip.NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663408);
			GUIClip.NativeMethodInfoPtr_Internal_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663409);
			GUIClip.NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663410);
			GUIClip.NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663411);
			GUIClip.NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663412);
			GUIClip.NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663413);
			GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663414);
			GUIClip.NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663415);
			GUIClip.NativeMethodInfoPtr_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663416);
			GUIClip.NativeMethodInfoPtr_Pop_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663417);
			GUIClip.NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663418);
			GUIClip.NativeMethodInfoPtr_Internal_Push_Injected_Private_Static_Void_byref_Rect_byref_Vector2_byref_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663419);
			GUIClip.NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663420);
			GUIClip.NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663421);
			GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663422);
			GUIClip.get_enabledDelegateField = IL2CPP.ResolveICall<GUIClip.get_enabledDelegate>("UnityEngine.GUIClip::get_enabled");
			GUIClip.ReapplyDelegateField = IL2CPP.ResolveICall<GUIClip.ReapplyDelegate>("UnityEngine.GUIClip::Reapply");
			GUIClip.get_topmostRect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.get_topmostRect_InjectedDelegate>("UnityEngine.GUIClip::get_topmostRect_Injected");
			GUIClip.GetTopRect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.GetTopRect_InjectedDelegate>("UnityEngine.GUIClip::GetTopRect_Injected");
			GUIClip.Unclip_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Unclip_Vector2_InjectedDelegate>("UnityEngine.GUIClip::Unclip_Vector2_Injected");
			GUIClip.Unclip_Rect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Unclip_Rect_InjectedDelegate>("UnityEngine.GUIClip::Unclip_Rect_Injected");
			GUIClip.Clip_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Clip_Vector2_InjectedDelegate>("UnityEngine.GUIClip::Clip_Vector2_Injected");
			GUIClip.Internal_Clip_Rect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Internal_Clip_Rect_InjectedDelegate>("UnityEngine.GUIClip::Internal_Clip_Rect_Injected");
			GUIClip.UnclipToWindow_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.UnclipToWindow_Vector2_InjectedDelegate>("UnityEngine.GUIClip::UnclipToWindow_Vector2_Injected");
			GUIClip.UnclipToWindow_Rect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.UnclipToWindow_Rect_InjectedDelegate>("UnityEngine.GUIClip::UnclipToWindow_Rect_Injected");
			GUIClip.ClipToWindow_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.ClipToWindow_Vector2_InjectedDelegate>("UnityEngine.GUIClip::ClipToWindow_Vector2_Injected");
			GUIClip.ClipToWindow_Rect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.ClipToWindow_Rect_InjectedDelegate>("UnityEngine.GUIClip::ClipToWindow_Rect_Injected");
			GUIClip.Internal_GetAbsoluteMousePosition_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Internal_GetAbsoluteMousePosition_InjectedDelegate>("UnityEngine.GUIClip::Internal_GetAbsoluteMousePosition_Injected");
			GUIClip.GetParentMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.GetParentMatrix_InjectedDelegate>("UnityEngine.GUIClip::GetParentMatrix_Injected");
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000092A0 File Offset: 0x000074A0
		public unsafe static Rect visibleRect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85650, XrefRangeEnd = 85652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000092D0 File Offset: 0x000074D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85652, XrefRangeEnd = 85654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000932C File Offset: 0x0000752C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85656, RefRangeEnd = 85657, XrefRangeStart = 85654, XrefRangeEnd = 85656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Pop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00009354 File Offset: 0x00007554
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 85659, RefRangeEnd = 85664, XrefRangeStart = 85657, XrefRangeEnd = 85659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00009384 File Offset: 0x00007584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85664, XrefRangeEnd = 85666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetMatrix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000093B4 File Offset: 0x000075B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85666, XrefRangeEnd = 85668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMatrix(Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000093E8 File Offset: 0x000075E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85670, RefRangeEnd = 85671, XrefRangeStart = 85668, XrefRangeEnd = 85670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectTransform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00009428 File Offset: 0x00007628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85673, RefRangeEnd = 85674, XrefRangeStart = 85671, XrefRangeEnd = 85673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_PopParentClip()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00009450 File Offset: 0x00007650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85674, XrefRangeEnd = 85676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000094AC File Offset: 0x000076AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85656, RefRangeEnd = 85657, XrefRangeStart = 85656, XrefRangeEnd = 85657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Pop_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000094D4 File Offset: 0x000076D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85676, XrefRangeEnd = 85678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_visibleRect_Injected(out Rect ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009508 File Offset: 0x00007708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85678, XrefRangeEnd = 85680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scrollOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_Push_Injected_Private_Static_Void_byref_Rect_byref_Vector2_byref_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00009564 File Offset: 0x00007764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85680, XrefRangeEnd = 85682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetMatrix_Injected(out Matrix4x4 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00009598 File Offset: 0x00007798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85682, XrefRangeEnd = 85684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMatrix_Injected(ref Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000095CC File Offset: 0x000077CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85684, XrefRangeEnd = 85686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &objectTransform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &clipRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002681 File Offset: 0x00000881
		public GUIClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000268A File Offset: 0x0000088A
		public static bool enabled
		{
			get
			{
				return GUIClip.get_enabledDelegateField();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000960C File Offset: 0x0000780C
		public static Rect topmostRect
		{
			get
			{
				Rect rect;
				GUIClip.get_topmostRect_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00009624 File Offset: 0x00007824
		public static Rect GetTopRect()
		{
			Rect rect;
			GUIClip.GetTopRect_Injected(out rect);
			return rect;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000963C File Offset: 0x0000783C
		public static Vector2 Unclip_Vector2(Vector2 pos)
		{
			Vector2 vector;
			GUIClip.Unclip_Vector2_Injected(ref pos, out vector);
			return vector;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00009654 File Offset: 0x00007854
		public static Rect Unclip_Rect(Rect rect)
		{
			Rect rect2;
			GUIClip.Unclip_Rect_Injected(ref rect, out rect2);
			return rect2;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000966C File Offset: 0x0000786C
		public static Vector2 Clip_Vector2(Vector2 absolutePos)
		{
			Vector2 vector;
			GUIClip.Clip_Vector2_Injected(ref absolutePos, out vector);
			return vector;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00009684 File Offset: 0x00007884
		public static Rect Internal_Clip_Rect(Rect absoluteRect)
		{
			Rect rect;
			GUIClip.Internal_Clip_Rect_Injected(ref absoluteRect, out rect);
			return rect;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000969C File Offset: 0x0000789C
		public static Vector2 UnclipToWindow_Vector2(Vector2 pos)
		{
			Vector2 vector;
			GUIClip.UnclipToWindow_Vector2_Injected(ref pos, out vector);
			return vector;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000096B4 File Offset: 0x000078B4
		public static Rect UnclipToWindow_Rect(Rect rect)
		{
			Rect rect2;
			GUIClip.UnclipToWindow_Rect_Injected(ref rect, out rect2);
			return rect2;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000096CC File Offset: 0x000078CC
		public static Vector2 ClipToWindow_Vector2(Vector2 absolutePos)
		{
			Vector2 vector;
			GUIClip.ClipToWindow_Vector2_Injected(ref absolutePos, out vector);
			return vector;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000096E4 File Offset: 0x000078E4
		public static Rect ClipToWindow_Rect(Rect absoluteRect)
		{
			Rect rect;
			GUIClip.ClipToWindow_Rect_Injected(ref absoluteRect, out rect);
			return rect;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000096FC File Offset: 0x000078FC
		public static Vector2 Internal_GetAbsoluteMousePosition()
		{
			Vector2 vector;
			GUIClip.Internal_GetAbsoluteMousePosition_Injected(out vector);
			return vector;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002696 File Offset: 0x00000896
		public static void Reapply()
		{
			GUIClip.ReapplyDelegateField();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00009714 File Offset: 0x00007914
		public static Matrix4x4 GetParentMatrix()
		{
			Matrix4x4 matrix4x;
			GUIClip.GetParentMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000972C File Offset: 0x0000792C
		public static Vector2 Unclip(Vector2 pos)
		{
			return GUIClip.Unclip_Vector2(pos);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00009744 File Offset: 0x00007944
		public static Rect Unclip(Rect rect)
		{
			return GUIClip.Unclip_Rect(rect);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000975C File Offset: 0x0000795C
		public static Vector2 Clip(Vector2 absolutePos)
		{
			return GUIClip.Clip_Vector2(absolutePos);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00009774 File Offset: 0x00007974
		public static Rect Clip(Rect absoluteRect)
		{
			return GUIClip.Internal_Clip_Rect(absoluteRect);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000978C File Offset: 0x0000798C
		public static Vector2 UnclipToWindow(Vector2 pos)
		{
			return GUIClip.UnclipToWindow_Vector2(pos);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000097A4 File Offset: 0x000079A4
		public static Rect UnclipToWindow(Rect rect)
		{
			return GUIClip.UnclipToWindow_Rect(rect);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000097BC File Offset: 0x000079BC
		public static Vector2 ClipToWindow(Vector2 absolutePos)
		{
			return GUIClip.ClipToWindow_Vector2(absolutePos);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000097D4 File Offset: 0x000079D4
		public static Rect ClipToWindow(Rect absoluteRect)
		{
			return GUIClip.ClipToWindow_Rect(absoluteRect);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000097EC File Offset: 0x000079EC
		public static Vector2 GetAbsoluteMousePosition()
		{
			return GUIClip.Internal_GetAbsoluteMousePosition();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000026A2 File Offset: 0x000008A2
		public static void get_topmostRect_Injected(out Rect ret)
		{
			GUIClip.get_topmostRect_InjectedDelegateField(out ret);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000026AF File Offset: 0x000008AF
		public static void GetTopRect_Injected(out Rect ret)
		{
			GUIClip.GetTopRect_InjectedDelegateField(out ret);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000026BC File Offset: 0x000008BC
		public static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret)
		{
			GUIClip.Unclip_Vector2_InjectedDelegateField(ref pos, out ret);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000026CA File Offset: 0x000008CA
		public static void Unclip_Rect_Injected(ref Rect rect, out Rect ret)
		{
			GUIClip.Unclip_Rect_InjectedDelegateField(ref rect, out ret);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000026D8 File Offset: 0x000008D8
		public static void Clip_Vector2_Injected(ref Vector2 absolutePos, out Vector2 ret)
		{
			GUIClip.Clip_Vector2_InjectedDelegateField(ref absolutePos, out ret);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000026E6 File Offset: 0x000008E6
		public static void Internal_Clip_Rect_Injected(ref Rect absoluteRect, out Rect ret)
		{
			GUIClip.Internal_Clip_Rect_InjectedDelegateField(ref absoluteRect, out ret);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000026F4 File Offset: 0x000008F4
		public static void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret)
		{
			GUIClip.UnclipToWindow_Vector2_InjectedDelegateField(ref pos, out ret);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002702 File Offset: 0x00000902
		public static void UnclipToWindow_Rect_Injected(ref Rect rect, out Rect ret)
		{
			GUIClip.UnclipToWindow_Rect_InjectedDelegateField(ref rect, out ret);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002710 File Offset: 0x00000910
		public static void ClipToWindow_Vector2_Injected(ref Vector2 absolutePos, out Vector2 ret)
		{
			GUIClip.ClipToWindow_Vector2_InjectedDelegateField(ref absolutePos, out ret);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000271E File Offset: 0x0000091E
		public static void ClipToWindow_Rect_Injected(ref Rect absoluteRect, out Rect ret)
		{
			GUIClip.ClipToWindow_Rect_InjectedDelegateField(ref absoluteRect, out ret);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000272C File Offset: 0x0000092C
		public static void Internal_GetAbsoluteMousePosition_Injected(out Vector2 ret)
		{
			GUIClip.Internal_GetAbsoluteMousePosition_InjectedDelegateField(out ret);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002739 File Offset: 0x00000939
		public static void GetParentMatrix_Injected(out Matrix4x4 ret)
		{
			GUIClip.GetParentMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Internal_Static_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Push_Injected_Private_Static_Void_byref_Rect_byref_Vector2_byref_Vector2_Boolean_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Rect_0;

		// Token: 0x040000E8 RID: 232
		private static readonly GUIClip.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly GUIClip.ReapplyDelegate ReapplyDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly GUIClip.get_topmostRect_InjectedDelegate get_topmostRect_InjectedDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly GUIClip.GetTopRect_InjectedDelegate GetTopRect_InjectedDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly GUIClip.Unclip_Vector2_InjectedDelegate Unclip_Vector2_InjectedDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly GUIClip.Unclip_Rect_InjectedDelegate Unclip_Rect_InjectedDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly GUIClip.Clip_Vector2_InjectedDelegate Clip_Vector2_InjectedDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly GUIClip.Internal_Clip_Rect_InjectedDelegate Internal_Clip_Rect_InjectedDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly GUIClip.UnclipToWindow_Vector2_InjectedDelegate UnclipToWindow_Vector2_InjectedDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly GUIClip.UnclipToWindow_Rect_InjectedDelegate UnclipToWindow_Rect_InjectedDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly GUIClip.ClipToWindow_Vector2_InjectedDelegate ClipToWindow_Vector2_InjectedDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly GUIClip.ClipToWindow_Rect_InjectedDelegate ClipToWindow_Rect_InjectedDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly GUIClip.Internal_GetAbsoluteMousePosition_InjectedDelegate Internal_GetAbsoluteMousePosition_InjectedDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly GUIClip.GetParentMatrix_InjectedDelegate GetParentMatrix_InjectedDelegateField;

		// Token: 0x02000053 RID: 83
		[StructLayout(2)]
		public struct ParentClipScope
		{
			// Token: 0x0600066E RID: 1646 RVA: 0x00016F50 File Offset: 0x00015150
			// Note: this type is marked as 'beforefieldinit'.
			static ParentClipScope()
			{
				Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, "ParentClipScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr);
				GUIClip.ParentClipScope.NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr, "m_Disposed");
				GUIClip.ParentClipScope.NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr, 100663423);
				GUIClip.ParentClipScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr, 100663424);
			}

			// Token: 0x0600066F RID: 1647 RVA: 0x00016FB8 File Offset: 0x000151B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85647, RefRangeEnd = 85648, XrefRangeStart = 85646, XrefRangeEnd = 85647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParentClipScope(Matrix4x4 objectTransform, Rect clipRect)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref objectTransform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.ParentClipScope.NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x00016FF8 File Offset: 0x000151F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85649, RefRangeEnd = 85650, XrefRangeStart = 85648, XrefRangeEnd = 85649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.ParentClipScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x00004AD4 File Offset: 0x00002CD4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr, ref this));
			}

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeFieldInfoPtr_m_Disposed;

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0;

			// Token: 0x0400034E RID: 846
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400034F RID: 847
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool m_Disposed;
		}

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000673 RID: 1651
		private delegate bool get_enabledDelegate();

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000675 RID: 1653
		private delegate void ReapplyDelegate();

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000677 RID: 1655
		private delegate void get_topmostRect_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000679 RID: 1657
		private delegate void GetTopRect_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600067B RID: 1659
		private delegate void Unclip_Vector2_InjectedDelegate(IntPtr pos, [Out] IntPtr ret);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600067D RID: 1661
		private delegate void Unclip_Rect_InjectedDelegate(IntPtr rect, [Out] IntPtr ret);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600067F RID: 1663
		private delegate void Clip_Vector2_InjectedDelegate(IntPtr absolutePos, [Out] IntPtr ret);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000681 RID: 1665
		private delegate void Internal_Clip_Rect_InjectedDelegate(IntPtr absoluteRect, [Out] IntPtr ret);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000683 RID: 1667
		private delegate void UnclipToWindow_Vector2_InjectedDelegate(IntPtr pos, [Out] IntPtr ret);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000685 RID: 1669
		private delegate void UnclipToWindow_Rect_InjectedDelegate(IntPtr rect, [Out] IntPtr ret);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000687 RID: 1671
		private delegate void ClipToWindow_Vector2_InjectedDelegate(IntPtr absolutePos, [Out] IntPtr ret);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000689 RID: 1673
		private delegate void ClipToWindow_Rect_InjectedDelegate(IntPtr absoluteRect, [Out] IntPtr ret);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600068B RID: 1675
		private delegate void Internal_GetAbsoluteMousePosition_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600068D RID: 1677
		private delegate void GetParentMatrix_InjectedDelegate([Out] IntPtr ret);
	}
}
