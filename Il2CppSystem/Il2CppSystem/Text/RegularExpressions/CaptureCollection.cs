using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004D RID: 77
	[Serializable]
	public class CaptureCollection : Object
	{
		// Token: 0x06000491 RID: 1169 RVA: 0x000225A8 File Offset: 0x000207A8
		// Note: this type is marked as 'beforefieldinit'.
		static CaptureCollection()
		{
			Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "CaptureCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr);
			CaptureCollection.NativeFieldInfoPtr__group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, "_group");
			CaptureCollection.NativeFieldInfoPtr__capcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, "_capcount");
			CaptureCollection.NativeFieldInfoPtr__captures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, "_captures");
			CaptureCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100663962);
			CaptureCollection.NativeMethodInfoPtr_get_Item_Public_get_Capture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100663963);
			CaptureCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100663964);
			CaptureCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100663965);
			CaptureCollection.NativeMethodInfoPtr_GetCapture_Internal_Capture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100663966);
			CaptureCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr, 100663967);
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0002268C File Offset: 0x0002088C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000172 RID: 370
		public unsafe Capture this[int i]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37651, XrefRangeEnd = 37652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_get_Item_Public_get_Capture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00022714 File Offset: 0x00020914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37652, XrefRangeEnd = 37654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00022764 File Offset: 0x00020964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37654, XrefRangeEnd = 37658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000227A4 File Offset: 0x000209A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 37660, RefRangeEnd = 37664, XrefRangeStart = 37658, XrefRangeEnd = 37660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Capture GetCapture(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr_GetCapture_Internal_Capture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000227F0 File Offset: 0x000209F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37664, XrefRangeEnd = 37667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaptureCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaptureCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00003B66 File Offset: 0x00001D66
		public CaptureCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0002282C File Offset: 0x00020A2C
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003B6F File Offset: 0x00001D6F
		public unsafe Group _group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Group>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0002285C File Offset: 0x00020A5C
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00003B8E File Offset: 0x00001D8E
		public unsafe int _capcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__capcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__capcount)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00022884 File Offset: 0x00020A84
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00003BA9 File Offset: 0x00001DA9
		public unsafe Il2CppReferenceArray<Capture> _captures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__captures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Capture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureCollection.NativeFieldInfoPtr__captures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr__group;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr__capcount;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr__captures;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Capture_Int32_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_GetCapture_Internal_Capture_Int32_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
