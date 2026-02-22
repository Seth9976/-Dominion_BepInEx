using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033B RID: 827
	public sealed class SafeSerializationEventArgs : EventArgs
	{
		// Token: 0x06003566 RID: 13670 RVA: 0x001047BC File Offset: 0x001029BC
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSerializationEventArgs()
		{
			Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SafeSerializationEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr);
			SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, "m_streamingContext");
			SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, "m_serializedStates");
			SafeSerializationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, 100671553);
			SafeSerializationEventArgs.NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, 100671554);
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x0010483C File Offset: 0x00102A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343380, XrefRangeEnd = 343390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationEventArgs(StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x0010488C File Offset: 0x00102A8C
		public unsafe IList<Object> SerializedStates
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationEventArgs.NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00013188 File Offset: 0x00011388
		public SafeSerializationEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x001048CC File Offset: 0x00102ACC
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x00013191 File Offset: 0x00011391
		public StreamingContext m_streamingContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x001048FC File Offset: 0x00102AFC
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x000131BF File Offset: 0x000113BF
		public unsafe List<Object> m_serializedStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D26 RID: 11558
		private static readonly IntPtr NativeFieldInfoPtr_m_streamingContext;

		// Token: 0x04002D27 RID: 11559
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedStates;

		// Token: 0x04002D28 RID: 11560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0;

		// Token: 0x04002D29 RID: 11561
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0;
	}
}
