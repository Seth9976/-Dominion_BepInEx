using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D3 RID: 211
	public sealed class RenderChainTextEntry : ValueType
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x0003117C File Offset: 0x0002F37C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderChainTextEntry()
		{
			Il2CppClassPointerStore<RenderChainTextEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "RenderChainTextEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChainTextEntry>.NativeClassPtr);
			RenderChainTextEntry.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainTextEntry>.NativeClassPtr, "command");
			RenderChainTextEntry.NativeFieldInfoPtr_firstVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainTextEntry>.NativeClassPtr, "firstVertex");
			RenderChainTextEntry.NativeFieldInfoPtr_vertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainTextEntry>.NativeClassPtr, "vertexCount");
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00007913 File Offset: 0x00005B13
		public RenderChainTextEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0000791C File Offset: 0x00005B1C
		public RenderChainTextEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderChainTextEntry>.NativeClassPtr))
		{
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x000311E8 File Offset: 0x0002F3E8
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x0000792E File Offset: 0x00005B2E
		public unsafe RenderChainCommand command
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainTextEntry.NativeFieldInfoPtr_command);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainTextEntry.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00031218 File Offset: 0x0002F418
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x0000794D File Offset: 0x00005B4D
		public unsafe int firstVertex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainTextEntry.NativeFieldInfoPtr_firstVertex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainTextEntry.NativeFieldInfoPtr_firstVertex)) = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00031240 File Offset: 0x0002F440
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00007968 File Offset: 0x00005B68
		public unsafe int vertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainTextEntry.NativeFieldInfoPtr_vertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainTextEntry.NativeFieldInfoPtr_vertexCount)) = value;
			}
		}

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeFieldInfoPtr_command;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr_firstVertex;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_vertexCount;
	}
}
