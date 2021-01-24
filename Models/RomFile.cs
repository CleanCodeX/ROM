using System.IO;
using System.Runtime.InteropServices;
using IO.Models;

// ReSharper disable VirtualMemberCallInConstructor

namespace ROM.Models
{
	/// <summary>Provides load and save functionality for a generic segmented ROM file</summary>
	/// <typeparam name="TRom">The file's ROM type</typeparam>
	/// <typeparam name="TRomSegment">The file's S-RAM data segment type</typeparam> 
	public class RomFile<TRom, TRomSegment> : SegmentFile<TRom, TRomSegment>
		where TRom : struct
		where TRomSegment : struct
	{
		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRom,TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="buffer">The buffer which will be copied</param>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomFile(byte[] buffer, int segmentOffset) : base(buffer, segmentOffset) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRom,TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="stream">The stream the buffers will be loaded from</param>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomFile(Stream stream, int segmentOffset) : base(stream, segmentOffset) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRom,TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomFile(int segmentOffset) : base(Marshal.SizeOf<TRom>(), segmentOffset) { }
	}

	/// <summary>Provides load and save functionality for a partial generic segmented ROM file</summary>
	/// <typeparam name="TRomSegment">The file's S-RAM data segment type</typeparam> 
	public class RomSegmentFile<TRomSegment> : SegmentFile<TRomSegment>
		where TRomSegment : struct
	{
		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="stream">The stream the buffers will be loaded from</param>
		/// <param name="segmentSize">The size of the segment</param>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomSegmentFile(Stream stream, int segmentSize, int segmentOffset) : base(stream, segmentSize, segmentOffset) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="buffer">The buffer which will be copied</param>
		/// <param name="segmentSize">The size of the segment</param>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomSegmentFile(byte[] buffer, int segmentSize, int segmentOffset) : base(buffer, segmentSize, segmentOffset) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="size">The size of the buffer to create</param>
		/// <param name="segmentSize">The size of the segment</param>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomSegmentFile(int size, int segmentSize, int segmentOffset) : base(size, segmentSize, segmentOffset) { }
	}

	/// <summary>Provides load and save functionality for a generic non-segmented ROM file</summary>
	/// <typeparam name="TRom">The file's ROM type</typeparam>
	public class RomFile<TRom> : StructFile<TRom>
		where TRom : struct
	{
		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="stream">The stream the buffers will be loaded from</param>
		public RomFile(Stream stream) : base(stream) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="buffer">The buffer which will be copied</param>
		public RomFile(byte[] buffer) : base(buffer) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile{TRomSegment}"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="size">The size of the buffer to create</param>
		public RomFile(int size) : base(size) { }
	}

	/// <summary>Provides load and save functionality for a non-generic segmented ROM file</summary>
	public class RomSegmentFile : SegmentFile
	{
		/// <summary>
		/// Creates an instance of <see cref="RomFile"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="stream">The stream the buffers will be loaded from</param>
		/// <param name="segmentSize">The size of the segment</param>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomSegmentFile(Stream stream, int segmentSize, int segmentOffset) : base(stream, segmentSize, segmentOffset) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="buffer">The buffer which will be copied</param>
		/// <param name="segmentSize">The size of the segment</param>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomSegmentFile(byte[] buffer, int segmentSize, int segmentOffset) : base(buffer, segmentSize, segmentOffset) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="size">The size of the buffer to create</param>
		/// <param name="segmentSize">The size of the segment</param>
		/// <param name="segmentOffset">The offset of first save slot in ROM</param>
		public RomSegmentFile(int size, int segmentSize, int segmentOffset) : base(size, segmentSize, segmentOffset) { }
	}

	/// <summary>Provides load and save functionality for a non-generic non-segmented ROM file</summary>
	public class RomFile : BlobFile
	{
		/// <summary>
		/// Creates an instance of <see cref="RomFile"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="stream">The stream the buffers will be loaded from</param>
		public RomFile(Stream stream) : base(stream) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="buffer">The buffer which will be copied</param>
		public RomFile(byte[] buffer) : base(buffer) { }

		/// <summary>
		/// Creates an instance of <see cref="RomFile"/> and loads content from stream into buffer and ROM structure
		/// </summary>
		/// <param name="size">The size of the buffer to create</param>
		public RomFile(int size) : base(size) { }
	}
}