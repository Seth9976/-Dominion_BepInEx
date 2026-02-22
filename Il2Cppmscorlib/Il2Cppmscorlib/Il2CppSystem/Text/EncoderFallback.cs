using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000167 RID: 359
	[Serializable]
	public class EncoderFallback : Object
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x0008ECA8 File Offset: 0x0008CEA8
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallback()
		{
			Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr);
			EncoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "bIsMicrosoftBestFitFallback");
			EncoderFallback.NativeFieldInfoPtr_replacementFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "replacementFallback");
			EncoderFallback.NativeFieldInfoPtr_exceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "exceptionFallback");
			EncoderFallback.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "s_InternalSyncObject");
			EncoderFallback.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667318);
			EncoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667319);
			EncoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667320);
			EncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667321);
			EncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667322);
			EncoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667323);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x0008EDA0 File Offset: 0x0008CFA0
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310412, XrefRangeEnd = 310421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0008EDD4 File Offset: 0x0008CFD4
		public unsafe static EncoderFallback ReplacementFallback
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 310448, RefRangeEnd = 310450, XrefRangeStart = 310421, XrefRangeEnd = 310448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x0008EE08 File Offset: 0x0008D008
		public unsafe static EncoderFallback ExceptionFallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310450, XrefRangeEnd = 310475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0008EE3C File Offset: 0x0008D03C
		[CallerCount(0)]
		public unsafe virtual EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0008EE88 File Offset: 0x0008D088
		public unsafe virtual int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0008EED0 File Offset: 0x0008D0D0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00008815 File Offset: 0x00006A15
		public EncoderFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x0008EF0C File Offset: 0x0008D10C
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x0000881E File Offset: 0x00006A1E
		public unsafe bool bIsMicrosoftBestFitFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback)) = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x0008EF34 File Offset: 0x0008D134
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x00008839 File Offset: 0x00006A39
		public unsafe static EncoderFallback replacementFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncoderFallback.NativeFieldInfoPtr_replacementFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncoderFallback.NativeFieldInfoPtr_replacementFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x0008EF5C File Offset: 0x0008D15C
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0000884B File Offset: 0x00006A4B
		public unsafe static EncoderFallback exceptionFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncoderFallback.NativeFieldInfoPtr_exceptionFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncoderFallback.NativeFieldInfoPtr_exceptionFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x0008EF84 File Offset: 0x0008D184
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x0000885D File Offset: 0x00006A5D
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncoderFallback.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncoderFallback.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeFieldInfoPtr_bIsMicrosoftBestFitFallback;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeFieldInfoPtr_replacementFallback;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeFieldInfoPtr_exceptionFallback;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
