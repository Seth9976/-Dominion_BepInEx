using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000163 RID: 355
	public sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06001805 RID: 6149 RVA: 0x0008E0FC File Offset: 0x0008C2FC
		// Note: this type is marked as 'beforefieldinit'.
		static InternalEncoderBestFitFallbackBuffer()
		{
			Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalEncoderBestFitFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr);
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "cBestFit");
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "oFallback");
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "iCount");
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "iSize");
			InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, "s_InternalSyncObject");
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667294);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalEncoderBestFitFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667295);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667296);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667297);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667298);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667299);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667300);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667301);
			InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr, 100667302);
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x0008E244 File Offset: 0x0008C444
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310267, XrefRangeEnd = 310276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0008E278 File Offset: 0x0008C478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310289, RefRangeEnd = 310290, XrefRangeStart = 310276, XrefRangeEnd = 310289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalEncoderBestFitFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalEncoderBestFitFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0008E2C4 File Offset: 0x0008C4C4
		[CallerCount(0)]
		public unsafe override bool Fallback(char charUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknown;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0008E31C File Offset: 0x0008C51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310290, XrefRangeEnd = 310297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknownHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x0008E384 File Offset: 0x0008C584
		[CallerCount(0)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0008E3C0 File Offset: 0x0008C5C0
		[CallerCount(0)]
		public unsafe override bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0008E3FC File Offset: 0x0008C5FC
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0008E438 File Offset: 0x0008C638
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0008E46C File Offset: 0x0008C66C
		[CallerCount(0)]
		public unsafe char TryBestFit(char cUnknown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cUnknown;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00008703 File Offset: 0x00006903
		public InternalEncoderBestFitFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x0008E4B8 File Offset: 0x0008C6B8
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x0000870C File Offset: 0x0000690C
		public unsafe char cBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit)) = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x0008E4E0 File Offset: 0x0008C6E0
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x00008727 File Offset: 0x00006927
		public unsafe InternalEncoderBestFitFallback oFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalEncoderBestFitFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x0008E510 File Offset: 0x0008C710
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00008746 File Offset: 0x00006946
		public unsafe int iCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0008E538 File Offset: 0x0008C738
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x00008761 File Offset: 0x00006961
		public unsafe int iSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize)) = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0008E560 File Offset: 0x0008C760
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x0000877C File Offset: 0x0000697C
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InternalEncoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeFieldInfoPtr_cBestFit;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeFieldInfoPtr_oFallback;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeFieldInfoPtr_iCount;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeFieldInfoPtr_iSize;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InternalEncoderBestFitFallback_0;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_TryBestFit_Private_Char_Char_0;
	}
}
