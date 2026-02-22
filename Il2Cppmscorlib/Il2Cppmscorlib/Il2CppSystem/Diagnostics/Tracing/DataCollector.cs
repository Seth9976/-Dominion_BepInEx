using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C3 RID: 1219
	public sealed class DataCollector : ValueType
	{
		// Token: 0x060047A9 RID: 18345 RVA: 0x00149220 File Offset: 0x00147420
		// Note: this type is marked as 'beforefieldinit'.
		static DataCollector()
		{
			Il2CppClassPointerStore<DataCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "DataCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataCollector>.NativeClassPtr);
			DataCollector.NativeFieldInfoPtr_ThreadInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "ThreadInstance");
			DataCollector.NativeFieldInfoPtr_scratchEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "scratchEnd");
			DataCollector.NativeFieldInfoPtr_datasEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "datasEnd");
			DataCollector.NativeFieldInfoPtr_pinsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "pinsEnd");
			DataCollector.NativeFieldInfoPtr_datasStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "datasStart");
			DataCollector.NativeFieldInfoPtr_scratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "scratch");
			DataCollector.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "datas");
			DataCollector.NativeFieldInfoPtr_pins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "pins");
			DataCollector.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "buffer");
			DataCollector.NativeFieldInfoPtr_bufferPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "bufferPos");
			DataCollector.NativeFieldInfoPtr_bufferNesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "bufferNesting");
			DataCollector.NativeFieldInfoPtr_writingScalars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "writingScalars");
			DataCollector.NativeMethodInfoPtr_Enable_Internal_Void_ptr_Byte_Int32_ptr_EventData_Int32_ptr_GCHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673914);
			DataCollector.NativeMethodInfoPtr_Disable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673915);
			DataCollector.NativeMethodInfoPtr_Finish_Internal_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673916);
			DataCollector.NativeMethodInfoPtr_AddScalar_Internal_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673917);
			DataCollector.NativeMethodInfoPtr_AddBinary_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673918);
			DataCollector.NativeMethodInfoPtr_AddBinary_Internal_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673919);
			DataCollector.NativeMethodInfoPtr_AddArray_Internal_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673920);
			DataCollector.NativeMethodInfoPtr_BeginBufferedArray_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673921);
			DataCollector.NativeMethodInfoPtr_EndBufferedArray_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673922);
			DataCollector.NativeMethodInfoPtr_BeginBuffered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673923);
			DataCollector.NativeMethodInfoPtr_EndBuffered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673924);
			DataCollector.NativeMethodInfoPtr_EnsureBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673925);
			DataCollector.NativeMethodInfoPtr_EnsureBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673926);
			DataCollector.NativeMethodInfoPtr_GrowBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673927);
			DataCollector.NativeMethodInfoPtr_PinArray_Private_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673928);
			DataCollector.NativeMethodInfoPtr_ScalarsBegin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673929);
			DataCollector.NativeMethodInfoPtr_ScalarsEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100673930);
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x00149494 File Offset: 0x00147694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365983, RefRangeEnd = 365984, XrefRangeStart = 365983, XrefRangeEnd = 365983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(byte* scratch, int scratchSize, EventSource.EventData* datas, int dataCount, GCHandle* pins, int pinCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = scratch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scratchSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = datas;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pins;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pinCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_Enable_Internal_Void_ptr_Byte_Int32_ptr_EventData_Int32_ptr_GCHandle_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x0014951C File Offset: 0x0014771C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365984, RefRangeEnd = 365986, XrefRangeStart = 365984, XrefRangeEnd = 365984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_Disable_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x00149554 File Offset: 0x00147754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365987, RefRangeEnd = 365988, XrefRangeStart = 365986, XrefRangeEnd = 365987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource.EventData* Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_Finish_Internal_ptr_EventData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x0014958C File Offset: 0x0014778C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 365992, RefRangeEnd = 366013, XrefRangeStart = 365988, XrefRangeEnd = 365992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(void* value, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_AddScalar_Internal_Void_ptr_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x001495DC File Offset: 0x001477DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366028, RefRangeEnd = 366029, XrefRangeStart = 366013, XrefRangeEnd = 366028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(string value, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_AddBinary_Internal_Void_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x00149634 File Offset: 0x00147834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366030, RefRangeEnd = 366031, XrefRangeStart = 366029, XrefRangeEnd = 366030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(Array value, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_AddBinary_Internal_Void_Array_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x0014968C File Offset: 0x0014788C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 366038, RefRangeEnd = 366057, XrefRangeStart = 366031, XrefRangeEnd = 366038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Array value, int length, int itemSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_AddArray_Internal_Void_Array_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x001496F0 File Offset: 0x001478F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366058, RefRangeEnd = 366059, XrefRangeStart = 366057, XrefRangeEnd = 366058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BeginBufferedArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_BeginBufferedArray_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x00149734 File Offset: 0x00147934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366062, RefRangeEnd = 366063, XrefRangeStart = 366059, XrefRangeEnd = 366062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_EndBufferedArray_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x00149788 File Offset: 0x00147988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366063, XrefRangeEnd = 366064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBuffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_BeginBuffered_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x001497C0 File Offset: 0x001479C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366064, XrefRangeEnd = 366066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndBuffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_EndBuffered_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x001497F8 File Offset: 0x001479F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 366069, RefRangeEnd = 366075, XrefRangeStart = 366066, XrefRangeEnd = 366069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_EnsureBuffer_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x00149830 File Offset: 0x00147A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366075, XrefRangeEnd = 366078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureBuffer(int additionalSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref additionalSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_EnsureBuffer_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x00149874 File Offset: 0x00147A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366078, XrefRangeEnd = 366081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowBuffer(int required)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref required;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_GrowBuffer_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x001498B8 File Offset: 0x00147AB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 366089, RefRangeEnd = 366092, XrefRangeStart = 366081, XrefRangeEnd = 366089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PinArray(Object value, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_PinArray_Private_Void_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x00149910 File Offset: 0x00147B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366097, RefRangeEnd = 366098, XrefRangeStart = 366092, XrefRangeEnd = 366097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScalarsBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_ScalarsBegin_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x00149948 File Offset: 0x00147B48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 366099, RefRangeEnd = 366103, XrefRangeStart = 366098, XrefRangeEnd = 366099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScalarsEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_ScalarsEnd_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x0001B149 File Offset: 0x00019349
		public DataCollector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x0001B152 File Offset: 0x00019352
		public DataCollector()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataCollector>.NativeClassPtr))
		{
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x00149980 File Offset: 0x00147B80
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x0001B164 File Offset: 0x00019364
		public unsafe static DataCollector ThreadInstance
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(DataCollector.NativeFieldInfoPtr_ThreadInstance, intPtr);
				return new DataCollector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataCollector.NativeFieldInfoPtr_ThreadInstance, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x001499BC File Offset: 0x00147BBC
		// (set) Token: 0x060047C0 RID: 18368 RVA: 0x0001B17B File Offset: 0x0001937B
		public unsafe byte* scratchEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_scratchEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_scratchEnd)) = value;
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x001499E0 File Offset: 0x00147BE0
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x0001B196 File Offset: 0x00019396
		public unsafe EventSource.EventData* datasEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datasEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datasEnd)) = value;
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x00149A04 File Offset: 0x00147C04
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x0001B1B1 File Offset: 0x000193B1
		public unsafe GCHandle* pinsEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_pinsEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_pinsEnd)) = value;
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x00149A28 File Offset: 0x00147C28
		// (set) Token: 0x060047C6 RID: 18374 RVA: 0x0001B1CC File Offset: 0x000193CC
		public unsafe EventSource.EventData* datasStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datasStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datasStart)) = value;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x00149A4C File Offset: 0x00147C4C
		// (set) Token: 0x060047C8 RID: 18376 RVA: 0x0001B1E7 File Offset: 0x000193E7
		public unsafe byte* scratch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_scratch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_scratch)) = value;
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x00149A70 File Offset: 0x00147C70
		// (set) Token: 0x060047CA RID: 18378 RVA: 0x0001B202 File Offset: 0x00019402
		public unsafe EventSource.EventData* datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datas);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datas)) = value;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x00149A94 File Offset: 0x00147C94
		// (set) Token: 0x060047CC RID: 18380 RVA: 0x0001B21D File Offset: 0x0001941D
		public unsafe GCHandle* pins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_pins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_pins)) = value;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x00149AB8 File Offset: 0x00147CB8
		// (set) Token: 0x060047CE RID: 18382 RVA: 0x0001B238 File Offset: 0x00019438
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060047CF RID: 18383 RVA: 0x00149AE8 File Offset: 0x00147CE8
		// (set) Token: 0x060047D0 RID: 18384 RVA: 0x0001B257 File Offset: 0x00019457
		public unsafe int bufferPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_bufferPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_bufferPos)) = value;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x00149B10 File Offset: 0x00147D10
		// (set) Token: 0x060047D2 RID: 18386 RVA: 0x0001B272 File Offset: 0x00019472
		public unsafe int bufferNesting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_bufferNesting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_bufferNesting)) = value;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x00149B38 File Offset: 0x00147D38
		// (set) Token: 0x060047D4 RID: 18388 RVA: 0x0001B28D File Offset: 0x0001948D
		public unsafe bool writingScalars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_writingScalars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_writingScalars)) = value;
			}
		}

		// Token: 0x04003A07 RID: 14855
		private static readonly IntPtr NativeFieldInfoPtr_ThreadInstance;

		// Token: 0x04003A08 RID: 14856
		private static readonly IntPtr NativeFieldInfoPtr_scratchEnd;

		// Token: 0x04003A09 RID: 14857
		private static readonly IntPtr NativeFieldInfoPtr_datasEnd;

		// Token: 0x04003A0A RID: 14858
		private static readonly IntPtr NativeFieldInfoPtr_pinsEnd;

		// Token: 0x04003A0B RID: 14859
		private static readonly IntPtr NativeFieldInfoPtr_datasStart;

		// Token: 0x04003A0C RID: 14860
		private static readonly IntPtr NativeFieldInfoPtr_scratch;

		// Token: 0x04003A0D RID: 14861
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x04003A0E RID: 14862
		private static readonly IntPtr NativeFieldInfoPtr_pins;

		// Token: 0x04003A0F RID: 14863
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04003A10 RID: 14864
		private static readonly IntPtr NativeFieldInfoPtr_bufferPos;

		// Token: 0x04003A11 RID: 14865
		private static readonly IntPtr NativeFieldInfoPtr_bufferNesting;

		// Token: 0x04003A12 RID: 14866
		private static readonly IntPtr NativeFieldInfoPtr_writingScalars;

		// Token: 0x04003A13 RID: 14867
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Internal_Void_ptr_Byte_Int32_ptr_EventData_Int32_ptr_GCHandle_Int32_0;

		// Token: 0x04003A14 RID: 14868
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Internal_Void_0;

		// Token: 0x04003A15 RID: 14869
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_ptr_EventData_0;

		// Token: 0x04003A16 RID: 14870
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Internal_Void_ptr_Void_Int32_0;

		// Token: 0x04003A17 RID: 14871
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Internal_Void_String_Int32_0;

		// Token: 0x04003A18 RID: 14872
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Internal_Void_Array_Int32_0;

		// Token: 0x04003A19 RID: 14873
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Internal_Void_Array_Int32_Int32_0;

		// Token: 0x04003A1A RID: 14874
		private static readonly IntPtr NativeMethodInfoPtr_BeginBufferedArray_Internal_Int32_0;

		// Token: 0x04003A1B RID: 14875
		private static readonly IntPtr NativeMethodInfoPtr_EndBufferedArray_Internal_Void_Int32_Int32_0;

		// Token: 0x04003A1C RID: 14876
		private static readonly IntPtr NativeMethodInfoPtr_BeginBuffered_Internal_Void_0;

		// Token: 0x04003A1D RID: 14877
		private static readonly IntPtr NativeMethodInfoPtr_EndBuffered_Internal_Void_0;

		// Token: 0x04003A1E RID: 14878
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBuffer_Private_Void_0;

		// Token: 0x04003A1F RID: 14879
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBuffer_Private_Void_Int32_0;

		// Token: 0x04003A20 RID: 14880
		private static readonly IntPtr NativeMethodInfoPtr_GrowBuffer_Private_Void_Int32_0;

		// Token: 0x04003A21 RID: 14881
		private static readonly IntPtr NativeMethodInfoPtr_PinArray_Private_Void_Object_Int32_0;

		// Token: 0x04003A22 RID: 14882
		private static readonly IntPtr NativeMethodInfoPtr_ScalarsBegin_Private_Void_0;

		// Token: 0x04003A23 RID: 14883
		private static readonly IntPtr NativeMethodInfoPtr_ScalarsEnd_Private_Void_0;
	}
}
