using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x02000009 RID: 9
	public sealed class DownloadHandlerBuffer : DownloadHandler
	{
		// Token: 0x0600011C RID: 284 RVA: 0x000064F0 File Offset: 0x000046F0
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandlerBuffer()
		{
			Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "DownloadHandlerBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr);
			DownloadHandlerBuffer.NativeFieldInfoPtr_m_NativeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, "m_NativeData");
			DownloadHandlerBuffer.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663402);
			DownloadHandlerBuffer.NativeMethodInfoPtr_InternalCreateBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663403);
			DownloadHandlerBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663404);
			DownloadHandlerBuffer.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663405);
			DownloadHandlerBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663406);
			DownloadHandlerBuffer.NativeMethodInfoPtr_CreateNativeArrayForNativeData_Internal_Static_Void_byref_NativeArray_1_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663407);
			DownloadHandlerBuffer.NativeMethodInfoPtr_DisposeNativeArray_Internal_Static_Void_byref_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr, 100663408);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000065C0 File Offset: 0x000047C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124809, XrefRangeEnd = 124811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(DownloadHandlerBuffer obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00006604 File Offset: 0x00004804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124811, XrefRangeEnd = 124813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalCreateBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_InternalCreateBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006638 File Offset: 0x00004838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124816, RefRangeEnd = 124817, XrefRangeStart = 124813, XrefRangeEnd = 124816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006674 File Offset: 0x00004874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124817, XrefRangeEnd = 124828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NativeArray<byte> GetNativeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<byte>(intPtr);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000066AC File Offset: 0x000048AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124828, XrefRangeEnd = 124835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000066E0 File Offset: 0x000048E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124835, XrefRangeEnd = 124838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_CreateNativeArrayForNativeData_Internal_Static_Void_byref_NativeArray_1_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00006734 File Offset: 0x00004934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124838, XrefRangeEnd = 124841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeNativeArray(ref NativeArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerBuffer.NativeMethodInfoPtr_DisposeNativeArray_Internal_Static_Void_byref_NativeArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002586 File Offset: 0x00000786
		public DownloadHandlerBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000676C File Offset: 0x0000496C
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000258F File Offset: 0x0000078F
		public NativeArray<byte> m_NativeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandlerBuffer.NativeFieldInfoPtr_m_NativeData);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandlerBuffer.NativeFieldInfoPtr_m_NativeData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000679C File Offset: 0x0000499C
		public static string GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerBuffer>(www).text;
		}

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_m_NativeData;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerBuffer_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateBuffer_Private_Void_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeData_Protected_Virtual_NativeArray_1_Byte_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_CreateNativeArrayForNativeData_Internal_Static_Void_byref_NativeArray_1_Byte_ptr_Byte_Int32_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_DisposeNativeArray_Internal_Static_Void_byref_NativeArray_1_Byte_0;
	}
}
