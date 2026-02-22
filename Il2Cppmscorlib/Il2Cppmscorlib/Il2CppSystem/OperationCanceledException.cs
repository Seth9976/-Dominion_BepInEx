using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000D6 RID: 214
	[Serializable]
	public class OperationCanceledException : SystemException
	{
		// Token: 0x06000E3B RID: 3643 RVA: 0x00062F34 File Offset: 0x00061134
		// Note: this type is marked as 'beforefieldinit'.
		static OperationCanceledException()
		{
			Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OperationCanceledException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr);
			OperationCanceledException.NativeFieldInfoPtr__cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, "_cancellationToken");
			OperationCanceledException.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665702);
			OperationCanceledException.NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665703);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665704);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665705);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665706);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665707);
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00062FF0 File Offset: 0x000611F0
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00063028 File Offset: 0x00061228
		public unsafe CancellationToken CancellationToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00063070 File Offset: 0x00061270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290289, RefRangeEnd = 290291, XrefRangeStart = 290284, XrefRangeEnd = 290289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000630AC File Offset: 0x000612AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290293, RefRangeEnd = 290294, XrefRangeStart = 290291, XrefRangeEnd = 290293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000630F8 File Offset: 0x000612F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290296, RefRangeEnd = 290299, XrefRangeStart = 290294, XrefRangeEnd = 290296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(string message, CancellationToken token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0006315C File Offset: 0x0006135C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00005A64 File Offset: 0x00003C64
		public OperationCanceledException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000631C0 File Offset: 0x000613C0
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x00005A6D File Offset: 0x00003C6D
		public CancellationToken _cancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperationCanceledException.NativeFieldInfoPtr__cancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperationCanceledException.NativeFieldInfoPtr__cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr__cancellationToken;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
