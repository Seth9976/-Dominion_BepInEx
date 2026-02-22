using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015C RID: 348
	[Serializable]
	public class DecoderFallback : Object
	{
		// Token: 0x06001797 RID: 6039 RVA: 0x0008C288 File Offset: 0x0008A488
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderFallback()
		{
			Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr);
			DecoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "bIsMicrosoftBestFitFallback");
			DecoderFallback.NativeFieldInfoPtr_replacementFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "replacementFallback");
			DecoderFallback.NativeFieldInfoPtr_exceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "exceptionFallback");
			DecoderFallback.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "s_InternalSyncObject");
			DecoderFallback.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667234);
			DecoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667235);
			DecoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667236);
			DecoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667237);
			DecoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667238);
			DecoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667239);
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0008C380 File Offset: 0x0008A580
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309890, XrefRangeEnd = 309899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0008C3B4 File Offset: 0x0008A5B4
		public unsafe static DecoderFallback ReplacementFallback
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 309926, RefRangeEnd = 309928, XrefRangeStart = 309899, XrefRangeEnd = 309926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x0008C3E8 File Offset: 0x0008A5E8
		public unsafe static DecoderFallback ExceptionFallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309928, XrefRangeEnd = 309953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0008C41C File Offset: 0x0008A61C
		[CallerCount(0)]
		public unsafe virtual DecoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0008C468 File Offset: 0x0008A668
		public unsafe virtual int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0008C4B0 File Offset: 0x0008A6B0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x000084DD File Offset: 0x000066DD
		public DecoderFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0008C4EC File Offset: 0x0008A6EC
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x000084E6 File Offset: 0x000066E6
		public unsafe bool bIsMicrosoftBestFitFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback)) = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x0008C514 File Offset: 0x0008A714
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x00008501 File Offset: 0x00006701
		public unsafe static DecoderFallback replacementFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecoderFallback.NativeFieldInfoPtr_replacementFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecoderFallback.NativeFieldInfoPtr_replacementFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x0008C53C File Offset: 0x0008A73C
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x00008513 File Offset: 0x00006713
		public unsafe static DecoderFallback exceptionFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecoderFallback.NativeFieldInfoPtr_exceptionFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecoderFallback.NativeFieldInfoPtr_exceptionFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0008C564 File Offset: 0x0008A764
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x00008525 File Offset: 0x00006725
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecoderFallback.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecoderFallback.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeFieldInfoPtr_bIsMicrosoftBestFitFallback;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeFieldInfoPtr_replacementFallback;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeFieldInfoPtr_exceptionFallback;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
