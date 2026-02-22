using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Profiling.Experimental;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x020000EA RID: 234
	public sealed class MemoryProfiler : Object
	{
		// Token: 0x06001466 RID: 5222 RVA: 0x0004E87C File Offset: 0x0004CA7C
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryProfiler()
		{
			Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling.Memory.Experimental", "MemoryProfiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr);
			MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SnapshotFinished");
			MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SaveScreenshotToDisk");
			MemoryProfiler.NativeFieldInfoPtr_createMetaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "createMetaData");
			MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100664763);
			MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100664764);
			MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100664765);
			MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100664766);
			MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100664767);
			MemoryProfiler.StartOperationDelegateField = IL2CPP.ResolveICall<MemoryProfiler.StartOperationDelegate>("UnityEngine.Profiling.Memory.Experimental.MemoryProfiler::StartOperation");
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0004E95C File Offset: 0x0004CB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79555, XrefRangeEnd = 79578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PrepareMetadata()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0004E990 File Offset: 0x0004CB90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79578, RefRangeEnd = 79580, XrefRangeStart = 79578, XrefRangeEnd = 79578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteIntToByteArray(Il2CppStructArray<byte> array, int offset, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0004E9F0 File Offset: 0x0004CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79580, XrefRangeEnd = 79581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteStringToByteArray(Il2CppStructArray<byte> array, int offset, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0004EA54 File Offset: 0x0004CC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79581, XrefRangeEnd = 79586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinalizeSnapshot(string path, bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0004EA98 File Offset: 0x0004CC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79586, XrefRangeEnd = 79594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0000BC02 File Offset: 0x00009E02
		public MemoryProfiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0004EB24 File Offset: 0x0004CD24
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x0000BC0B File Offset: 0x00009E0B
		public unsafe static Action<string, bool> m_SnapshotFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0004EB4C File Offset: 0x0004CD4C
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0000BC1D File Offset: 0x00009E1D
		public unsafe static Action<string, bool, UnityEngine.Profiling.Experimental.DebugScreenCapture> m_SaveScreenshotToDisk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool, UnityEngine.Profiling.Experimental.DebugScreenCapture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0004EB74 File Offset: 0x0004CD74
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0000BC2F File Offset: 0x00009E2F
		public unsafe static Action<MetaData> createMetaData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_createMetaData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MetaData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_createMetaData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0000BC41 File Offset: 0x00009E41
		public static void add_createMetaData(Action<MetaData> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0000BC4E File Offset: 0x00009E4E
		public static void remove_createMetaData(Action<MetaData> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0000BC5B File Offset: 0x00009E5B
		public static void StartOperation(uint captureFlag, bool requestScreenshot, string path, bool isRemote)
		{
			MemoryProfiler.StartOperationDelegateField(captureFlag, requestScreenshot, IL2CPP.ManagedStringToIl2Cpp(path), isRemote);
		}

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_m_SnapshotFinished;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_m_SaveScreenshotToDisk;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_createMetaData;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly MemoryProfiler.StartOperationDelegate StartOperationDelegateField;

		// Token: 0x02000886 RID: 2182
		// (Invoke) Token: 0x06002EBF RID: 11967
		private delegate void StartOperationDelegate(uint captureFlag, bool requestScreenshot, IntPtr path, bool isRemote);
	}
}
