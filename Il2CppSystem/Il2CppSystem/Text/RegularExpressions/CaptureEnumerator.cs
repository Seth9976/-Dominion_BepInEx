using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004E RID: 78
	[Serializable]
	public class CaptureEnumerator : Object
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x000228B4 File Offset: 0x00020AB4
		// Note: this type is marked as 'beforefieldinit'.
		static CaptureEnumerator()
		{
			Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "CaptureEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr);
			CaptureEnumerator.NativeFieldInfoPtr__rcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr, "_rcc");
			CaptureEnumerator.NativeFieldInfoPtr__curindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr, "_curindex");
			CaptureEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_CaptureCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr, 100663968);
			CaptureEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr, 100663969);
			CaptureEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr, 100663970);
			CaptureEnumerator.NativeMethodInfoPtr_get_Capture_Public_get_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr, 100663971);
			CaptureEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr, 100663972);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00022970 File Offset: 0x00020B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37667, XrefRangeEnd = 37668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaptureEnumerator(CaptureCollection rcc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaptureEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rcc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_CaptureCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000229BC File Offset: 0x00020BBC
		[CallerCount(0)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000229F8 File Offset: 0x00020BF8
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37668, XrefRangeEnd = 37677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00022A38 File Offset: 0x00020C38
		public unsafe Capture Capture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureEnumerator.NativeMethodInfoPtr_get_Capture_Public_get_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00022A78 File Offset: 0x00020C78
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaptureEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public CaptureEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00022AAC File Offset: 0x00020CAC
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00003BD1 File Offset: 0x00001DD1
		public unsafe CaptureCollection _rcc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureEnumerator.NativeFieldInfoPtr__rcc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CaptureCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureEnumerator.NativeFieldInfoPtr__rcc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00022ADC File Offset: 0x00020CDC
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public unsafe int _curindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureEnumerator.NativeFieldInfoPtr__curindex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaptureEnumerator.NativeFieldInfoPtr__curindex)) = value;
			}
		}

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr__rcc;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr__curindex;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CaptureCollection_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_get_Capture_Public_get_Capture_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
