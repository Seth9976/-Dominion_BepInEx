using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Foundation.Animation;
using UnityEngine;

// Token: 0x02000007 RID: 7
public static class SA_Extensions_RectTransform : global::Il2CppSystem.Object
{
	// Token: 0x0600002B RID: 43 RVA: 0x0000445C File Offset: 0x0000265C
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_RectTransform()
	{
		Il2CppClassPointerStore<SA_Extensions_RectTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_RectTransform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_RectTransform>.NativeClassPtr);
		SA_Extensions_RectTransform.NativeMethodInfoPtr_Reset_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_RectTransform>.NativeClassPtr, 100663327);
		SA_Extensions_RectTransform.NativeMethodInfoPtr_MoveTo_Public_Static_Void_RectTransform_Object_Vector2_Single_SA_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_RectTransform>.NativeClassPtr, 100663328);
		SA_Extensions_RectTransform.NativeMethodInfoPtr_GetScreenRect_Public_Static_Rect_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_RectTransform>.NativeClassPtr, 100663329);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000044C8 File Offset: 0x000026C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98306, XrefRangeEnd = 98315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Reset(this RectTransform rt)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_RectTransform.NativeMethodInfoPtr_Reset_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00004500 File Offset: 0x00002700
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98315, XrefRangeEnd = 98350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveTo(this RectTransform transform, global::Il2CppSystem.Object callbackTarget, Vector2 position, float time, SA_EaseType easeType = SA_EaseType.linear, Action OnCompleteAction = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_RectTransform.NativeMethodInfoPtr_MoveTo_Public_Static_Void_RectTransform_Object_Vector2_Single_SA_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00004588 File Offset: 0x00002788
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98350, XrefRangeEnd = 98378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect GetScreenRect(this RectTransform transform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_RectTransform.NativeMethodInfoPtr_GetScreenRect_Public_Static_Rect_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000020D6 File Offset: 0x000002D6
	public SA_Extensions_RectTransform(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_RectTransform_0;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Static_Void_RectTransform_Object_Vector2_Single_SA_EaseType_Action_0;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_GetScreenRect_Public_Static_Rect_RectTransform_0;

	// Token: 0x02000043 RID: 67
	[ObfuscatedName("SA_Extensions_RectTransform+<>c__DisplayClass1_0")]
	public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x000126A0 File Offset: 0x000108A0
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass1_0()
		{
			Il2CppClassPointerStore<SA_Extensions_RectTransform.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Extensions_RectTransform>.NativeClassPtr, "<>c__DisplayClass1_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_RectTransform.__c__DisplayClass1_0>.NativeClassPtr);
			SA_Extensions_RectTransform.__c__DisplayClass1_0.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Extensions_RectTransform.__c__DisplayClass1_0>.NativeClassPtr, "transform");
			SA_Extensions_RectTransform.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_RectTransform.__c__DisplayClass1_0>.NativeClassPtr, 100663864);
			SA_Extensions_RectTransform.__c__DisplayClass1_0.NativeMethodInfoPtr__MoveTo_b__0_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_RectTransform.__c__DisplayClass1_0>.NativeClassPtr, 100663865);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00012708 File Offset: 0x00010908
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass1_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Extensions_RectTransform.__c__DisplayClass1_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_RectTransform.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00012744 File Offset: 0x00010944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98299, XrefRangeEnd = 98306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _MoveTo_b__0(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_RectTransform.__c__DisplayClass1_0.NativeMethodInfoPtr__MoveTo_b__0_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002F4F File Offset: 0x0000114F
		public __c__DisplayClass1_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00012784 File Offset: 0x00010984
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00002F58 File Offset: 0x00001158
		public unsafe RectTransform transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Extensions_RectTransform.__c__DisplayClass1_0.NativeFieldInfoPtr_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Extensions_RectTransform.__c__DisplayClass1_0.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr__MoveTo_b__0_Internal_Void_Vector3_0;
	}
}
