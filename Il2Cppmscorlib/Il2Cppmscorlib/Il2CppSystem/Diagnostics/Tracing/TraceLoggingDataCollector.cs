using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000504 RID: 1284
	public class TraceLoggingDataCollector : Object
	{
		// Token: 0x06004985 RID: 18821 RVA: 0x0015113C File Offset: 0x0014F33C
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingDataCollector()
		{
			Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingDataCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr);
			TraceLoggingDataCollector.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, "Instance");
			TraceLoggingDataCollector.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674172);
			TraceLoggingDataCollector.NativeMethodInfoPtr_BeginBufferedArray_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674173);
			TraceLoggingDataCollector.NativeMethodInfoPtr_EndBufferedArray_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674174);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674175);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674176);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674177);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674178);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674179);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674180);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674181);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674182);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674183);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674184);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674185);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674186);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674187);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674188);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674189);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674190);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674191);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674192);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674193);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674194);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674195);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674196);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674197);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674198);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674199);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674200);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674201);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674202);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674203);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674204);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674205);
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00151428 File Offset: 0x0014F628
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingDataCollector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00151464 File Offset: 0x0014F664
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369700, RefRangeEnd = 369702, XrefRangeStart = 369696, XrefRangeEnd = 369700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BeginBufferedArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_BeginBufferedArray_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x001514A0 File Offset: 0x0014F6A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369711, RefRangeEnd = 369713, XrefRangeStart = 369702, XrefRangeEnd = 369711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndBufferedArray(int bookmark, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bookmark;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_EndBufferedArray_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x001514EC File Offset: 0x0014F6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369717, RefRangeEnd = 369718, XrefRangeStart = 369713, XrefRangeEnd = 369717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x0015152C File Offset: 0x0014F72C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 369722, RefRangeEnd = 369745, XrefRangeStart = 369718, XrefRangeEnd = 369722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(sbyte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x0015156C File Offset: 0x0014F76C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 369749, RefRangeEnd = 369763, XrefRangeStart = 369745, XrefRangeEnd = 369749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x001515AC File Offset: 0x0014F7AC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 369767, RefRangeEnd = 369777, XrefRangeStart = 369763, XrefRangeEnd = 369767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x001515EC File Offset: 0x0014F7EC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 369781, RefRangeEnd = 369803, XrefRangeStart = 369777, XrefRangeEnd = 369781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x0015162C File Offset: 0x0014F82C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 369807, RefRangeEnd = 369830, XrefRangeStart = 369803, XrefRangeEnd = 369807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x0015166C File Offset: 0x0014F86C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 369834, RefRangeEnd = 369856, XrefRangeStart = 369830, XrefRangeEnd = 369834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x001516AC File Offset: 0x0014F8AC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 369860, RefRangeEnd = 369887, XrefRangeStart = 369856, XrefRangeEnd = 369860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x001516EC File Offset: 0x0014F8EC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 369891, RefRangeEnd = 369913, XrefRangeStart = 369887, XrefRangeEnd = 369891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x0015172C File Offset: 0x0014F92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369918, RefRangeEnd = 369919, XrefRangeStart = 369913, XrefRangeEnd = 369918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(IntPtr value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x0015176C File Offset: 0x0014F96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369919, XrefRangeEnd = 369926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(UIntPtr value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UIntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x001517AC File Offset: 0x0014F9AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369930, RefRangeEnd = 369931, XrefRangeStart = 369926, XrefRangeEnd = 369930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x001517EC File Offset: 0x0014F9EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369935, RefRangeEnd = 369937, XrefRangeStart = 369931, XrefRangeEnd = 369935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x0015182C File Offset: 0x0014FA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369941, RefRangeEnd = 369942, XrefRangeStart = 369937, XrefRangeEnd = 369941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x0015186C File Offset: 0x0014FA6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369946, RefRangeEnd = 369947, XrefRangeStart = 369942, XrefRangeEnd = 369946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(Guid value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x001518AC File Offset: 0x0014FAAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369954, RefRangeEnd = 369955, XrefRangeStart = 369947, XrefRangeEnd = 369954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x001518F0 File Offset: 0x0014FAF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369962, RefRangeEnd = 369963, XrefRangeStart = 369955, XrefRangeEnd = 369962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00151934 File Offset: 0x0014FB34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369970, RefRangeEnd = 369971, XrefRangeStart = 369963, XrefRangeEnd = 369970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00151978 File Offset: 0x0014FB78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369978, RefRangeEnd = 369979, XrefRangeStart = 369971, XrefRangeEnd = 369978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<sbyte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x001519BC File Offset: 0x0014FBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369986, RefRangeEnd = 369987, XrefRangeStart = 369979, XrefRangeEnd = 369986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<short> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x00151A00 File Offset: 0x0014FC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369987, XrefRangeEnd = 369994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<ushort> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x00151A44 File Offset: 0x0014FC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370001, RefRangeEnd = 370002, XrefRangeStart = 369994, XrefRangeEnd = 370001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x00151A88 File Offset: 0x0014FC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370002, XrefRangeEnd = 370009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<uint> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00151ACC File Offset: 0x0014FCCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370016, RefRangeEnd = 370017, XrefRangeStart = 370009, XrefRangeEnd = 370016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<long> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00151B10 File Offset: 0x0014FD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370017, XrefRangeEnd = 370024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<ulong> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00151B54 File Offset: 0x0014FD54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370032, RefRangeEnd = 370033, XrefRangeStart = 370024, XrefRangeEnd = 370032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<IntPtr> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x00151B98 File Offset: 0x0014FD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370033, XrefRangeEnd = 370043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<UIntPtr> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UIntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00151BDC File Offset: 0x0014FDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370050, RefRangeEnd = 370051, XrefRangeStart = 370043, XrefRangeEnd = 370050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00151C20 File Offset: 0x0014FE20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370058, RefRangeEnd = 370059, XrefRangeStart = 370051, XrefRangeEnd = 370058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<double> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x00151C64 File Offset: 0x0014FE64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370066, RefRangeEnd = 370067, XrefRangeStart = 370059, XrefRangeEnd = 370066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x00151CA8 File Offset: 0x0014FEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370074, RefRangeEnd = 370075, XrefRangeStart = 370067, XrefRangeEnd = 370074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<Guid> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x0001B993 File Offset: 0x00019B93
		public TraceLoggingDataCollector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x00151CEC File Offset: 0x0014FEEC
		// (set) Token: 0x060049AA RID: 18858 RVA: 0x0001B99C File Offset: 0x00019B9C
		public unsafe static TraceLoggingDataCollector Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TraceLoggingDataCollector.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingDataCollector>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceLoggingDataCollector.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B45 RID: 15173
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04003B46 RID: 15174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003B47 RID: 15175
		private static readonly IntPtr NativeMethodInfoPtr_BeginBufferedArray_Public_Int32_0;

		// Token: 0x04003B48 RID: 15176
		private static readonly IntPtr NativeMethodInfoPtr_EndBufferedArray_Public_Void_Int32_Int32_0;

		// Token: 0x04003B49 RID: 15177
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Boolean_0;

		// Token: 0x04003B4A RID: 15178
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_SByte_0;

		// Token: 0x04003B4B RID: 15179
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Byte_0;

		// Token: 0x04003B4C RID: 15180
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Int16_0;

		// Token: 0x04003B4D RID: 15181
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_UInt16_0;

		// Token: 0x04003B4E RID: 15182
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0;

		// Token: 0x04003B4F RID: 15183
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_UInt32_0;

		// Token: 0x04003B50 RID: 15184
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Int64_0;

		// Token: 0x04003B51 RID: 15185
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_UInt64_0;

		// Token: 0x04003B52 RID: 15186
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_IntPtr_0;

		// Token: 0x04003B53 RID: 15187
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_UIntPtr_0;

		// Token: 0x04003B54 RID: 15188
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Single_0;

		// Token: 0x04003B55 RID: 15189
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Double_0;

		// Token: 0x04003B56 RID: 15190
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Char_0;

		// Token: 0x04003B57 RID: 15191
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Guid_0;

		// Token: 0x04003B58 RID: 15192
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Public_Void_String_0;

		// Token: 0x04003B59 RID: 15193
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003B5A RID: 15194
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04003B5B RID: 15195
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_SByte_0;

		// Token: 0x04003B5C RID: 15196
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int16_0;

		// Token: 0x04003B5D RID: 15197
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04003B5E RID: 15198
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003B5F RID: 15199
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04003B60 RID: 15200
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int64_0;

		// Token: 0x04003B61 RID: 15201
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt64_0;

		// Token: 0x04003B62 RID: 15202
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_IntPtr_0;

		// Token: 0x04003B63 RID: 15203
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UIntPtr_0;

		// Token: 0x04003B64 RID: 15204
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x04003B65 RID: 15205
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Double_0;

		// Token: 0x04003B66 RID: 15206
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04003B67 RID: 15207
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Guid_0;
	}
}
